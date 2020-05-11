<template>
    <div class="agents">
        <h1>Agents</h1>
        <table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Address</th>
                    <th>City</th>
                    <th>State</th>
                    <th>Zip</th>
                    <th>Tier</th>
                    <th>Phone</th>
                    <td></td>
                </tr>
            </thead>
            <tbody>
                <tr v-for="agent in agents" :key="agent.id">
                    <td>{{ agent.id }}</td>
                    <td>{{ agent.name }}</td>
                    <td>{{ agent.address }}</td>
                    <td>{{ agent.city }}</td>
                    <td>{{ agent.state }}</td>
                    <td>{{ agent.zipCode }}</td>
                    <td>{{ agent.tier }}</td>
                    <td>Main: {{ agent.phone.primary }}<br />Mobile: {{ agent.phone.mobile }}</td>
                    <td>
                        <edit-buttons id="agent.id" />
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import EditButtons from './Buttons.vue';

    export default {
        name: 'Agents',
        components: {
            EditButtons
        },
        data() {
            return {
                agents: [],
                error: ''
            }
        },
        created() {
            this.getAgents('https://localhost:44352/api/v1/Agents');
        },
        methods: {
            getAgents: function(url) {
                this.$http.get(url).then(result => {
                    this.agents = result.body;
                });
            },
            edit: function (id) {
                alert(id);
            },
            save: function () {

            }
        }
    };
</script>

<style scoped>
    table, th, td {
        border: solid 1px #000;
    }
</style>