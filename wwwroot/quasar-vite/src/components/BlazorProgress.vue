<template>
  <div class="q-pa-md">
    <q-btn size="sm" color="primary" @click="randomize" label="Change Model" />

    <q-linear-progress :value="progress" class="q-mt-md" />

    <q-linear-progress :value="progress" color="warning" class="q-mt-sm" />

    <q-linear-progress :value="progress" color="secondary" class="q-mt-sm" />

    <q-linear-progress
      :value="progress"
      rounded
      color="accent"
      class="q-mt-sm"
    />

    <q-linear-progress
      :value="progress"
      rounded
      color="purple"
      track-color="orange"
      class="q-mt-sm"
    />

    <q-linear-progress
      :value="progress"
      rounded
      color="negative"
      class="q-mt-sm"
    />
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType, computed, ref, toRef, Ref } from 'vue';

export default defineComponent({
  name: 'WTF',
  props: {
    title: {
      type: String,
      required: true,
    },
    active: {
      type: Boolean,
    },
  },
  computed: {
    progress_test() {
      return this.active ? Math.random() * 100 : 0;
    },
  },
  setup() {
    const progress = ref(0.4);

    return {
      progress,
      randomize() {
        progress.value = Math.random();
      },
    };
  },
});
</script>
