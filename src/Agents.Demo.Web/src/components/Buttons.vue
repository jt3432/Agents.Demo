<template>
    <div class="edit-buttons">
        <button type="button" v-on:click="edit(id)" v-if="!isEdit">Edit</button>
        <div v-if="isEdit">
            <button type="button" v-on:click="save(id)">Save</button>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'EditButtons',
        props: {
            id: Number
        },
        methods: {
            edit: function () {
                this.isEdit = !this.isEdit;
            },
            save: function () {
                this.isEdit = !this.isEdit;
            }
        },
        data: function () {
            return {
                isEdit: false
            }
        }
    };
</script>

<style scoped>
</style>