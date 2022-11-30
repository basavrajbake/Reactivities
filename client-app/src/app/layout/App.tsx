import React, { Fragment } from 'react';
import { Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';
import { observer } from 'mobx-react-lite';
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";
import HomePage from '../../features/home/HomePage';
import ActivityForm from '../../features/activities/form/ActivityForm';

const router = createBrowserRouter([
  {
    path: "/",
    element: <HomePage /> ,
  },
  {
    path:'/activities',
    element: <ActivityDashboard />,
  },
  {
    path:'/createActivity',
    element: <ActivityForm />,
  }
]);
function App() {
    return (
    <Fragment>
      <NavBar/>
      <Container style={{marginTop:'7em'}} >
      <RouterProvider router={router} />
      </Container>
    </Fragment>
  );
}

export default observer(App);
