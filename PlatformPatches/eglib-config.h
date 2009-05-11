#ifndef __EGLIB_CONFIG_H
#define __EGLIB_CONFIG_H

/*
 * System-dependent settings
 */
#define G_GNUC_PRETTY_FUNCTION   
#define G_GNUC_UNUSED            __attribute__((__unused__))
#define G_BYTE_ORDER             G_LITTLE_ENDIAN
#define G_GNUC_NORETURN          __attribute__((__noreturn__))
#define G_SEARCHPATH_SEPARATOR_S ":"
#define G_SEARCHPATH_SEPARATOR   ':'
#define G_DIR_SEPARATOR          '/'
#define G_DIR_SEPARATOR_S        "/"
#define G_BREAKPOINT()           G_STMT_START { raise (SIGTRAP); } G_STMT_END
#define G_OS_UNIX
#define GPOINTER_TO_INT(ptr)   ((gint) (ptr))
#define GPOINTER_TO_UINT(ptr)  ((guint) (ptr))
#define GINT_TO_POINTER(v)     ((gpointer) (v))
#define GUINT_TO_POINTER(v)    ((gpointer) (v))

typedef unsigned int gsize;
typedef signed   int gssize;

#define G_GSIZE_FORMAT   "u"
#define G_GUINT64_FORMAT "llu"

#endif
