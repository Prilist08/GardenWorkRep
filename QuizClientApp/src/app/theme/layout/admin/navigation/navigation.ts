export interface NavigationItem {
  id: string;
 title: string;
  type: 'item' | 'collapse' | 'group';
  translate?: string;
  icon?: string;
  hidden?: boolean;
  url?: string;
  classes?: string;
  exactMatch?: boolean;
  external?: boolean;
  target?: boolean;
  breadcrumbs?: boolean;
  badge?: {
    title?: string;
    type?: string;
  };
  children?: NavigationItem[];
}

export const NavigationItems: NavigationItem[] = [
  {
    id: 'navigation',
    title: 'Navigation',
    type: 'group',
    icon: 'icon-group',
    children: [
      {
        id: 'dashboard', 
        title: 'Dashboard',
        type: 'item',
        url: 'dashboard',
        icon: 'feather icon-home'
      }
    ]
  },
  {
    id: 'ui-component',
    title: 'Bookings',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Booking',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'New Booking',
            type: 'item',
            url: '/app/booking'
          },
          {
            id: 'badges',
            title: 'All Bookings',
            type: 'item',
            url: '/app/bookings'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Calendar View',
            type: 'item',
            url: '/app/#'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Pending Bookings',
            type: 'item',
            url: '/app/#'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Cancelled Bookings',
            type: 'item',
            url: '/app/#'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Bookings Payments',
            type: 'item',
            url: '/app/#'
          },
        ]
      }
    ]
  },

  {
    id: 'ui-component',
    title: 'Customers',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Customers',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'Add Customer',
            type: 'item',
            url: '/app/customer'
          },
          {
            id: 'badges',
            title: 'Customer List',
            type: 'item',
            url: '/app/customers'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Customer Booking History',
            type: 'item',
            url: '/app/#'
          }
        
        ]
      }
    ]
  },


  {
    id: 'ui-component',
    title: 'Events',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Events',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'Event Types',
            type: 'item',
            url: '/app/booking'
          },
          {
            id: 'badges',
            title: 'Event Packages',
            type: 'item',
            url: '/app/items'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Package Pricing',
            type: 'item',
            url: '/app/#'
          }

        ]
      }
    ]
  },


  {
    id: 'ui-component',
    title: 'Services',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Services',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'Add Service',
            type: 'item',
            url: '/app/service'
          },
          {
            id: 'button',
            title: 'Services List',
            type: 'item',
            url: '/app/services'
          },
          //{
          //  id: 'badges',
          //  title: 'Service Categories',
          //  type: 'item',
          //  url: '/app/items'
          //},
          //{
          //  id: 'breadcrumb-pagination',
          //  title: 'Service Pricing',
          //  type: 'item',
          //  url: '/app/services'
          //},
          {
            id: 'breadcrumb-pagination',
            title: 'Package Mapping',
            type: 'item',
            url: '/app/services'
          }

        ]
      }
    ]
  },

  {
    id: 'ui-component',
    title: 'Stock Master',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Stock',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'Add Item',
            type: 'item',
            url: '/app/item'
          },
          {
            id: 'button',
            title: 'Item List',
            type: 'item',
            url: '/app/items'
          },
          {
            id: 'badges',
            title: 'Add Category',
            type: 'item',
            url: '/app/category'
          },
          {
            id: 'badges',
            title: 'Category List',
            type: 'item',
            url: '/app/categorys'
          }
          //{
          //  id: 'breadcrumb-pagination',
          //  title: 'Unit Setup',
          //  type: 'item',
          //  url: '/app/services'
          //}
       

        ]
      }
    ]
  },


  {
    id: 'ui-component',
    title: 'Stock Transactions',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Stock',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'Purchase Entry',
            type: 'item',
            url: '/app/purchase'
          },
          {
            id: 'badges',
            title: 'Stock Usage (Event-wise)',
            type: 'item',
            url: '/app/stocktransaction'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Stock Adjustment',
            type: 'item',
            url: '/app/#'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Low Stock Alert',
            type: 'item',
            url: '/app/#'
          }


        ]
      }
    ]
  },
  {
    id: 'ui-component',
    title: 'Suppliers',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Suppliers',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'Add Supplier',
            type: 'item',
            url: '/app/supplier'
          },
          {
            id: 'badges',
            title: 'Supplier List',
            type: 'item',
            url: '/app/suppliers'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Supplier Payments',
            type: 'item',
            url: '/app/#'
          }
         


        ]
      }
    ]
  },

  {
    id: 'ui-component',
    title: 'Billing & Accounts',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Billing',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'Create Invoice',
            type: 'item',
            url: '/app/booking'
          },
          {
            id: 'badges',
            title: 'All Invoices',
            type: 'item',
            url: '/app/items'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Payments Received',
            type: 'item',
            url: '/app/services'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Expenses Entry',
            type: 'item',
            url: '/app/services'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'GST Report',
            type: 'item',
            url: '/app/services'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Profit & Loss Report',
            type: 'item',
            url: '/app/services'
          }



        ]
      }
    ]
  },

  {
    id: 'ui-component',
    title: 'Staff Management',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Staff',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'Add Staff',
            type: 'item',
            url: '/app/booking'
          },
          {
            id: 'badges',
            title: 'Roles & Permissions',
            type: 'item',
            url: '/app/items'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Salary Management',
            type: 'item',
            url: '/app/services'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Attendance',
            type: 'item',
            url: '/app/services'
          }
         



        ]
      }
    ]
  },

  {
    id: 'ui-component',
    title: 'Reports',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Revenue Report',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'Booking Report',
            type: 'item',
            url: '/component/button'
          },
          {
            id: 'badges',
            title: 'Event Type Report',
            type: 'item',
            url: '/component/badges'
          },
          {
            id: 'breadcrumb-pagination',
            title: 'Stock Report',
            type: 'item',
            url: '/component/breadcrumb-paging'
          },
          {
            id: 'collapse',
            title: 'Customer Report',
            type: 'item',
            url: '/component/collapse'
          },
          {
            id: 'collapse',
            title: 'Expense Report',
            type: 'item',
            url: '/component/collapse'
          }
       
        ]
      }
    ]
  },
  {
    id: 'ui-component',
    title: 'Settings',
    type: 'group',
    icon: 'feather icon-menu',
    children: [
      {
        id: 'basic',
        title: 'Company Profile',
        type: 'collapse',
        icon: 'feather icon-box',
        children: [
          {
            id: 'button',
            title: 'GST Settings',
            type: 'item',
            url: '/component/button'
          },
          {
            id: 'button',
            title: 'User Management',
            type: 'item',
            url: '/component/button'
          },
          {
            id: 'badges',
            title: 'Backup & Restore',
            type: 'item',
            url: '/component/badges'
          },
          {
            id: 'badges',
            title: 'Login Status',
            type: 'item',
            url: '/component/badges'
          }
         

        ]
      }
    ]
  },
  //{
  //  id: 'forms & tables',
  //  title: 'Master',
  //  type: 'group',
  //  icon: 'icon-group',
  //  children: [
  //    {
  //      id: 'button',
  //      title: 'Organization',
  //      type: 'item',
  //      url: '/organization',
  //      classes: 'nav-item',
  //      icon: 'feather icon-log-in',
  //    },
  //    {
  //      id: 'badges',
  //      title: 'Subject',
  //      type: 'item',
  //      url: '/subject',
  //      classes: 'nav-item',
  //      icon: 'feather icon-log-in',
  //    },
  //    {
  //      id: 'breadcrumb-pagination',
  //      title: 'Subject-Expert',
  //      type: 'item',
  //      url: '/subjectexpert',
  //      classes: 'nav-item',
  //      icon: 'feather icon-log-in',
  //    },

  //    {
  //      id: 'tabs-pills',
  //      title: 'event',
  //      type: 'item',
  //      url: '/event',
  //      classes: 'nav-item',
  //      icon: 'feather icon-log-in',
  //    },
  //    {
  //      id: 'collapse',
  //      title: 'Question Bank',
  //      type: 'item',
  //      url: '/questionbank',
  //       classes: 'nav-item',
  //      icon: 'feather icon-log-in',
  //    },



  //    {
  //      id: 'forms',
  //      title: 'Other 1',
  //      type: 'item',
  //      url: '/forms',
  //      classes: 'nav-item',
  //      icon: 'feather icon-file-text'
  //    },
  //    {
  //      id: 'tables',
  //      title: 'Other 2',
  //      type: 'item',
  //      url: '/tables',
  //      classes: 'nav-item',
  //      icon: 'feather icon-server'
  //    }
  //  ]
  //},
  //{
  //  id: 'other',
  //  title: 'Other',
  //  type: 'group',
  //  icon: 'icon-group',
  //  children: [
  //    {
  //      id: 'sample-page',
  //      title: 'Sample Page',
  //      type: 'item',
  //      url: '/sample-page',
  //      classes: 'nav-item',
  //      icon: 'feather icon-sidebar'
  //    },
  //    {
  //      id: 'menu-level',
  //      title: 'Menu Levels',
  //      type: 'collapse',
  //      icon: 'feather icon-menu',
  //      children: [
  //        {
  //          id: 'menu-level-2.1',
  //          title: 'Menu Level 2.1',
  //          type: 'item',
  //          url: 'javascript:',
  //          external: true
  //        },
  //        {
  //          id: 'menu-level-2.2',
  //          title: 'Menu Level 2.2',
  //          type: 'collapse',
  //          children: [
  //            {
  //              id: 'menu-level-2.2.1',
  //              title: 'Menu Level 2.2.1',
  //              type: 'item',
  //              url: 'javascript:',
  //              external: true
  //            },
  //            {
  //              id: 'menu-level-2.2.2',
  //              title: 'Menu Level 2.2.2',
  //              type: 'item',
  //              url: 'javascript:',
  //              external: true
  //            }
  //          ]
  //        }
  //      ]
  //    }
  //  ]
  //}

  //{
  //  id: 'navigation',
  //  title: 'Navigation',
  //  type: 'group',
  //  icon: 'icon-group',
  //  children: [
  //    {
  //      id: 'dashboard',
  //      title: 'Dashboard',
  //      type: 'item',
  //      url: '/analytics',
  //      icon: 'feather icon-home'
  //    }
  //  ]
  //},
  //{
  //  id: 'ui-component',
  //  title: 'Ui Component',
  //  type: 'group',
  //  icon: 'icon-group',
  //  children: [
  //    {
  //      id: 'basic',
  //      title: 'Component',
  //      type: 'collapse',
  //      icon: 'feather icon-box',
  //      children: [
  //        {
  //          id: 'button',
  //          title: 'Button',
  //          type: 'item',
  //          url: '/component/button'
  //        },
  //        {
  //          id: 'badges',
  //          title: 'Badges',
  //          type: 'item',
  //          url: '/component/badges'
  //        },
  //        {
  //          id: 'breadcrumb-pagination',
  //          title: 'Breadcrumb & Pagination',
  //          type: 'item',
  //          url: '/component/breadcrumb-paging'
  //        },
  //        {
  //          id: 'collapse',
  //          title: 'Collapse',
  //          type: 'item',
  //          url: '/component/collapse'
  //        },
  //        {
  //          id: 'tabs-pills',
  //          title: 'Tabs & Pills',
  //          type: 'item',
  //          url: '/component/tabs-pills'
  //        },
  //        {
  //          id: 'typography',
  //          title: 'Typography',
  //          type: 'item',
  //          url: '/component/typography'
  //        }
  //      ]
  //    }
  //  ]
  //},
  //{
  //  id: 'Authentication',
  //  title: 'Authentication',
  //  type: 'group',
  //  icon: 'icon-group',
  //  children: [
  //    {
  //      id: 'signup',
  //      title: 'Sign up',
  //      type: 'item',
  //      url: '/register',
  //      icon: 'feather icon-at-sign',
  //      target: true,
  //      breadcrumbs: false
  //    },
  //    {
  //      id: 'signin',
  //      title: 'Sign in',
  //      type: 'item',
  //      url: '/login',
  //      icon: 'feather icon-log-in',
  //      target: true,
  //      breadcrumbs: false
  //    }
  //  ]
  //},
  //{
  //  id: 'chart',
  //  title: 'Chart',
  //  type: 'group',
  //  icon: 'icon-group',
  //  children: [
  //    {
  //      id: 'apexchart',
  //      title: 'ApexChart',
  //      type: 'item',
  //      url: '/chart',
  //      classes: 'nav-item',
  //      icon: 'feather icon-pie-chart'
  //    }
  //  ]
  //},
  //{
  //  id: 'forms & tables',
  //  title: 'Forms & Tables',
  //  type: 'group',
  //  icon: 'icon-group',
  //  children: [
  //    {
  //      id: 'forms',
  //      title: 'Basic Forms',
  //      type: 'item',
  //      url: '/forms',
  //      classes: 'nav-item',
  //      icon: 'feather icon-file-text'
  //    },
  //    {
  //      id: 'tables',
  //      title: 'Tables',
  //      type: 'item',
  //      url: '/tables',
  //      classes: 'nav-item',
  //      icon: 'feather icon-server'
  //    }
  //  ]
  //},
  //{
  //  id: 'other',
  //  title: 'Other',
  //  type: 'group',
  //  icon: 'icon-group',
  //  children: [
  //    {
  //      id: 'sample-page',
  //      title: 'Sample Page',
  //      type: 'item',
  //      url: '/sample-page',
  //      classes: 'nav-item',
  //      icon: 'feather icon-sidebar'
  //    },
  //    {
  //      id: 'menu-level',
  //      title: 'Menu Levels',
  //      type: 'collapse',
  //      icon: 'feather icon-menu',
  //      children: [
  //        {
  //          id: 'menu-level-2.1',
  //          title: 'Menu Level 2.1',
  //          type: 'item',
  //          url: 'javascript:',
  //          external: true
  //        },
  //        {
  //          id: 'menu-level-2.2',
  //          title: 'Menu Level 2.2',
  //          type: 'collapse',
  //          children: [
  //            {
  //              id: 'menu-level-2.2.1',
  //              title: 'Menu Level 2.2.1',
  //              type: 'item',
  //              url: 'javascript:',
  //              external: true
  //            },
  //            {
  //              id: 'menu-level-2.2.2',
  //              title: 'Menu Level 2.2.2',
  //              type: 'item',
  //              url: 'javascript:',
  //              external: true
  //            }
  //          ]
  //        }
  //      ]
  //    }
  //  ]
  //}
];
