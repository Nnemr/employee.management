import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Management',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44344/',
    redirectUri: baseUrl,
    clientId: 'Management_App',
    responseType: 'code',
    scope: 'offline_access Management',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44344',
      rootNamespace: 'Employee.Management',
    },
  },
} as Environment;
