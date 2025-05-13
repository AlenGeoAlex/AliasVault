export type VaultResponse = {
    success: boolean, error?: string,
    vault?: string,
    publicEmailDomains?: string[],
    privateEmailDomains?: string[],
    vaultRevisionNumber?: number
};
