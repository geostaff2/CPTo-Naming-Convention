# VB.NET High-Security Authentication Procedure

This procedure implements a high-security sign-in model for a VB.NET desktop application where users must authenticate at startup and be re-verified during active sessions.

## 1) Define Security Requirements

Document and approve:
- Identity source (Entra ID / Okta / Auth0)
- MFA policy (always or risk-based)
- Access-token lifetime (recommended: 5-15 minutes)
- Re-verification interval (recommended: 10-30 minutes)
- Lockout thresholds (attempts, cooldown, admin unlock)
- Audit retention and SIEM forwarding requirements
- Compliance controls (for example ISO 27001, SOC 2, HIPAA, PCI DSS)

## 2) Select Identity Platform

Use an enterprise IdP with:
- OIDC/OAuth2 authorization code + PKCE
- Conditional access / adaptive risk policies
- Step-up MFA support
- Session revocation APIs
- Centralized audit logs and admin governance

## 3) Enforce Full Login at App Start

Implement browser-based sign-in only:
1. Launch system browser for OIDC login.
2. Require MFA per configured policy.
3. Exchange auth code for short-lived access token.
4. Save token material in OS-protected secure storage only.

Do not:
- Collect passwords in an embedded app form.
- Store plaintext credentials.

## 4) Enforce Server-Issued Session Control

Backend must:
- Validate bearer token on every API request.
- Bind user requests to a server-side session record.
- Track session state: `Active`, `Revoked`, `Expired`.
- Reject requests immediately when session is not active.

Client must:
- Block protected operations if session check fails.
- Force re-login when revoked/expired.

## 5) Add In-Session Re-Verification

Trigger re-verification:
- On a fixed timer (10-30 min)
- On sensitive actions (export, admin actions, financial changes)

Use step-up authentication:
1. Prompt user with IdP challenge (MFA).
2. Verify success server-side.
3. Resume restricted features only when verification succeeds.

## 6) Harden Transport and Secret Storage

- Enforce TLS 1.2+ (prefer 1.3) end-to-end.
- Pin API hostnames and validate certificates.
- Use platform secret stores (Windows DPAPI / Credential Manager) for tokens.
- Prefer short-lived tokens and controlled refresh-token policy.
- Rotate keys and revoke compromised sessions quickly.

## 7) Add Abuse Protections

Backend controls:
- Rate limiting by account, device, and IP.
- Progressive lockouts and anti-automation protections.
- Device trust signals and impossible-travel/risk checks.
- Risk score policies to require step-up MFA.

## 8) Build Audit and Monitoring

Log minimum events:
- Login success/failure
- Re-auth challenge success/failure
- Token refresh and token rejection
- Lockouts/unlocks
- Session revoke/expire
- Privileged/admin operations

Operational controls:
- Send logs to SIEM.
- Create alerts for brute force, token replay, and unusual session behavior.
- Periodically review and test alert quality.

## 9) Define Failure Handling

Choose policy explicitly:
- **Strict deny**: no server = no protected access
- **Grace window**: brief offline period with forced re-auth after expiry

Required behaviors:
- Clear user message with next step
- Automatic retry with backoff
- Admin recovery process for lockout/network incidents

## 10) Validate Before Full Rollout

Required validation set:
- Penetration test
- Token replay test
- MITM resilience checks
- Session timeout/revocation tests
- MFA bypass attempts
- Lockout and rate-limit verification

Release approach:
1. Pilot with small user group.
2. Monitor incidents and auth friction.
3. Tune policies.
4. Enforce globally.

---

## Minimum Implementation Checklist

- [ ] IdP app registration completed
- [ ] OIDC + PKCE flow implemented in VB.NET app
- [ ] Server-side token/session validation enabled on all APIs
- [ ] Session re-verification timer + sensitive-action checks active
- [ ] Secure token storage implemented
- [ ] Rate limits + lockouts configured
- [ ] SIEM ingestion + alerts operational
- [ ] Failure policy and runbook approved
- [ ] Security test suite passed
