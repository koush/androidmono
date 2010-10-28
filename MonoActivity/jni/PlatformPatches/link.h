#ifndef _LINK_H_
#define _LINK_H_

// These structures are needed by libgc
// They are defined in mydroid/bionic/linker/linker.h, but are expected to be in <link.h>
struct link_map
{
    uintptr_t l_addr;
    char * l_name;
    uintptr_t l_ld;
    struct link_map * l_next;
    struct link_map * l_prev;
};


struct r_debug
{
    int32_t r_version;
    struct link_map * r_map;
    void (*r_brk)(void);
    int32_t r_state;
    uintptr_t r_ldbase;
};

#endif
