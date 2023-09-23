<script>
  import {
    Label,
    Input,
    Tabs,
    TabItem,
    Table,
    TableHead,
    TableHeadCell,
  } from "flowbite-svelte";
  import ApiTest from "$lib/api-test.svelte";
</script>

<table>
  <tr>
    <td>
      <Label for="small-input" class="block mb-2">Name</Label>
      <div>
        <Input id="small-input" placeholder="Name" />
      </div>
    </td>
    <td>
      <Label for="small-input" class="block mb-2">Address 1</Label>
      <Input id="small-input" placeholder="Address 1" />
    </td>
    <td>
      <Label for="small-input" class="block mb-2">Phone</Label>
      <Input id="small-input" placeholder="Phone" />
    </td>
  </tr>
  <tr>
    <td />
    <td>
      <Label for="small-input" class="block mb-2">Address 2</Label>
      <Input id="small-input" placeholder="Address 2" />
    </td>
    <td>
      <Label for="small-input" class="block mb-2">Alt Phone</Label>
      <Input id="small-input" placeholder="Alt Phone" />
    </td>
  </tr>
  <tr>
    <td />
    <td>
      <Label for="small-input" class="block mb-2">City</Label>
      <Input id="small-input" placeholder="City" />
    </td>
    <td>
      <Label for="small-input" class="block mb-2">Fax</Label>
      <Input id="small-input" placeholder="Fax" />
    </td>
  </tr>
  <tr>
    <td />
    <td>
      <Label for="small-input" class="block mb-2">Province/State</Label>
      <Input id="small-input" placeholder="Province/State" />
    </td>
    <td>
      <Label for="small-input" class="block mb-2">Email</Label>
      <Input id="small-input" placeholder="Email" />
    </td>
  </tr>
  <tr>
    <td />
    <td>
      <Label for="small-input" class="block mb-2">Country</Label>
      <Input id="small-input" placeholder="Country" />
    </td>
  </tr>
  <tr>
    <td />
    <td>
      <Label for="small-input" class="block mb-2">Postal</Label>
      <Input id="small-input" placeholder="Postal" />
    </td>
  </tr>
</table>
<Tabs style="underline">
  <TabItem open title="Contacts">
    <Table>
      <TableHead>
        <TableHeadCell>First Name</TableHeadCell>
        <TableHeadCell>Last Name</TableHeadCell>
        <TableHeadCell>Phone</TableHeadCell>
        <TableHeadCell>Alt Phone</TableHeadCell>
        <TableHeadCell>Email</TableHeadCell>
      </TableHead>
    </Table>
  </TabItem>
  <TabItem title="Invoices">
    <ApiTest />
  </TabItem>
</Tabs>

<style>
  table {
    border-collapse: collapse;
    width: 100%;
  }

  td {
    padding: 3px;
    text-align: left;
  }
</style>
