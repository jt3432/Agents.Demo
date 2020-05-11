<template>
    <div id="app">
        <agents />
    </div>
</template>

<script>
    import Agents from './components/Agents.vue';

    export default {
        name: 'app',
        components: {            
            'agents': Agents
        }
    };
</script>

<style>
</style>

