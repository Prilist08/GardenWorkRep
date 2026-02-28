

// Angular Import
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
// project import
import { AppComponent } from './app.component';
import { AdminComponent } from './theme/layout/admin/admin.component';
import { SignInComponent } from './demo/pages/authentication/sign-in/sign-in.component';
import { GuestComponent } from './theme/layout/guest/guest.component';
import { CreateComponent } from './theme/layout/admin/org/create/create.component';
import { OrgComponent } from './theme/layout/admin/org/org.component';
import { SubjectComponent } from './theme/layout/admin/subject/subject.component';
import { SubjectExpertComponent } from './theme/layout/admin/subject-expert/subject-expert.component';
import { EventComponent } from './theme/layout/admin/event/event.component';
import { InstructionsComponent } from './theme/layout/admin/instructions/instructions.component';
import { SchedulingComponent } from './theme/layout/admin/scheduling/scheduling.component';
//Garden Master Import
import { CategorysComponent } from './Master/categorys/categorys.component';
import { CategoryComponent } from './Master/categorys/category/category.component';

import { CustomersComponent } from './Master/customers/customers.component';
import { CustomerComponent } from './Master/customers/customer/customer.component';
import { ItemsComponent } from './Master/items/items.component';
import { ItemComponent } from './Master/items/item/item.component';


import { ServicesComponent } from './Master/services/services.component';
import { ServiceComponent } from './Master/services/service/service.component';
import { SuppliersComponent } from './Master/suppliers/suppliers.component';
import { SupplierComponent } from './Master/suppliers/supplier/supplier.component';

import { BookingComponent } from './Operations/booking/booking.component';
import { PurchaseComponent } from './Operations/purchase/purchase.component';
import { StockTransactionsComponent } from './Operations/stock-transactions/stock-transactions.component';

export const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },

  // Login route (public)
  { path: 'login', component: SignInComponent },
  /*{ path: 'organization', component: OrgComponent },*/
  // Main app layout route (after login)
  {
    path: 'app',
    component: AdminComponent,
    children: [
      { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
      { path: 'dashboard', component: AdminComponent },
      /*   { path: 'organization', component: OrgComponent }*/
      {
        path: 'default',
        loadComponent: () => import('./theme/layout/admin/default/default.component').then((c) => c.DefaultComponent)
      },

      {
        path: 'organization',
        loadComponent: () => import('./theme/layout/admin/org/org.component').then((c) => c.OrgComponent)
      },
      {
        path: 'subject',
        loadComponent: () => import('./theme/layout/admin/subject/subject.component').then((c) => c.SubjectComponent)
      },
      {
        path: 'createsubject',
        loadComponent: () => import('./theme/layout/admin/subject/create/create.component').then((c) => c.CreateComponent)
      },
      {
        path: 'editsubject',
        loadComponent: () => import('./theme/layout/admin/subject/edit/edit.component').then((c) => c.EditComponent)
      },
      {
        path: 'subjectexpert',
        loadComponent: () => import('./theme/layout/admin/subject-expert/subject-expert.component').then((c) => c.SubjectExpertComponent)
      },
      {
        path: 'createsubjectexpert',
        loadComponent: () => import('./theme/layout/admin/subject-expert/create/create.component').then((c) => c.CreateComponent)
      },
      {
        path: 'editsubjectexpert',
        loadComponent: () => import('./theme/layout/admin/subject-expert/edit/edit.component').then((c) => c.EditComponent)
      },
      {
        path: 'event',
        loadComponent: () => import('./theme/layout/admin/event/event.component').then((c) => c.EventComponent)
      },
      {
        path: 'createevent',
        loadComponent: () => import('./theme/layout/admin/event/create/create.component').then((c) => c.CreateComponent)
      },
      {
        path: 'editevent',
        loadComponent: () => import('./theme/layout/admin/event/edit/edit.component').then((c) => c.EditComponent)
      },

      {
        path: 'instructions',
        loadComponent: () => import('./theme/layout/admin/instructions/instructions.component').then((c) => c.InstructionsComponent)
      },
      {
        path: 'creatinstruction',
        loadComponent: () => import('./theme/layout/admin/instructions/create/create.component').then((c) => c.CreateComponent)
      },
      {
        path: 'editinstruction',
        loadComponent: () => import('./theme/layout/admin/instructions/edit/edit.component').then((c) => c.EditComponent)
      },
      {
        path: 'scheduling',
        loadComponent: () => import('./theme/layout/admin/scheduling/scheduling.component').then((c) => c.SchedulingComponent)
      },
      {
        path: 'creatscheduling',
        loadComponent: () => import('./theme/layout/admin/scheduling/create/create.component').then((c) => c.CreateComponent)
      },
      {
        path: 'editscheduling',
        loadComponent: () => import('./theme/layout/admin/scheduling/edit/edit.component').then((c) => c.EditComponent)
      },


      {
        path: 'addorganization',
        loadComponent: () => import('./theme/layout/admin/org/create/create.component').then((c) => c.CreateComponent)
      },
      {
        path: 'editorganization',
        loadComponent: () => import('./theme/layout/admin/org/edit/edit.component').then((c) => c.EditComponent)
      },
      {
        path: 'analytics',
        loadComponent: () => import('./demo/dashboard/dash-analytics.component').then((c) => c.DashAnalyticsComponent)
      },
      {
        path: 'quiztitle',
        loadComponent: () => import('./theme/layout/admin/quiztitle/quiztitle.component').then((c) => c.QuiztitleComponent)
      },
      {
        path: 'createtitle',
        loadComponent: () => import('./theme/layout/admin/quiztitle/create/create.component').then((c) => c.CreateComponent)
      },


      //Garden Master Link
       {
        path: 'categorys',
         loadComponent: () => import('./Master/categorys/categorys.component').then((c) => c.CategorysComponent)
      },
      {
        path: 'category',
        loadComponent: () => import('./Master/categorys/category/category.component').then((c) => c.CategoryComponent)
      },
      {
        path: 'customers',
        loadComponent: () => import('./Master/customers/customers.component').then((c) => c.CustomersComponent)
      },
      {
        path: 'customer',
        loadComponent: () => import('./Master/customers/customer/customer.component').then((c) => c.CustomerComponent)
      },
      {
        path: 'items',
        loadComponent: () => import('./Master/items/items.component').then((c) => c.ItemsComponent)
      },
       {
        path: 'item',
         loadComponent: () => import('./Master/items/item/item.component').then((c) => c.ItemComponent)
      },
      {
        path: 'services',
        loadComponent: () => import('./Master/services/services.component').then((c) => c.ServicesComponent)
      },
      {
        path: 'service',
        loadComponent: () => import('./Master/services/service/service.component').then((c) => c.ServiceComponent)
      },
      {
        path: 'suppliers',
        loadComponent: () => import('./Master/suppliers/suppliers.component').then((c) => c.SuppliersComponent)
      },
      {
        path: 'supplier',
        loadComponent: () => import('./Master/suppliers/supplier/supplier.component').then((c) => c.SupplierComponent)
      },

      //Garden Operations Link
      {
        path: 'booking',
        loadComponent: () => import('./Operations/booking/booking.component').then((c) => c.BookingComponent)
      },
      {
        path: 'purchase',
        loadComponent: () => import('./Operations/purchase/purchase.component').then((c) => c.PurchaseComponent)
      },
      {
        path: 'stocktransaction',
        loadComponent: () => import('./Operations/stock-transactions/stock-transactions.component').then((c) => c.StockTransactionsComponent)
      }



    ]
  },

  // Wildcard redirect
  { path: '**', redirectTo: 'dashboard' }
];
@NgModule({

  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
