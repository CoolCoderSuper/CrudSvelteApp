<script>
  import "../app.postcss";
  import { page } from '$app/stores';
  import { Navbar, NavBrand, NavLi, NavUl, NavHamburger, DarkMode } from 'flowbite-svelte';
  $: activeUrl = $page.url.pathname;
  const routes = [
    { name: "Home", path: "/" },
    { name: "Customers", path: "/customers" },
    { name: "Counter", path: "/counter" },
  ];
</script>
<svelte:head>
  <title>Customer Manager</title>
</svelte:head>

<Navbar let:hidden let:toggle>
  <NavBrand href="/">
    <span class="self-center text-xl font-semibold dark:text-white">GuentherTech</span>
  </NavBrand>
  <div class="flex md:order-2">
    <DarkMode />
    <NavHamburger on:click={toggle} />
  </div>
  <NavUl {activeUrl} {hidden}>
    {#each routes as route}
      <NavLi href={route.path}>{route.name}</NavLi>
    {/each}
  </NavUl>
</Navbar>
<slot />
