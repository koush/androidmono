namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ContextMenu_))]
	public partial interface ContextMenu : Menu
	{
		global::android.view.ContextMenu setHeaderTitle(int arg0);
		global::android.view.ContextMenu setHeaderTitle(java.lang.CharSequence arg0);
		global::android.view.ContextMenu setHeaderIcon(int arg0);
		global::android.view.ContextMenu setHeaderIcon(android.graphics.drawable.Drawable arg0);
		global::android.view.ContextMenu setHeaderView(android.view.View arg0);
		void clearHeader();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ContextMenu))]
	public sealed partial class ContextMenu_ : java.lang.Object, ContextMenu
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContextMenu_()
		{
			InitJNI();
		}
		internal ContextMenu_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle13912;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderTitle13912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderTitle13912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle13913;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderTitle13913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderTitle13913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon13914;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderIcon13914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderIcon13914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon13915;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderIcon13915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderIcon13915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderView13916;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderView13916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderView13916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _clearHeader13917;
		 void android.view.ContextMenu.clearHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._clearHeader13917);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._clearHeader13917);
		}
		internal static global::MonoJavaBridge.MethodId _add13918;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add13918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add13918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add13919;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add13919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add13919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add13920;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add13920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add13920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add13921;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add13921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add13921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _clear13922;
		 void android.view.Menu.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._clear13922);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._clear13922);
		}
		internal static global::MonoJavaBridge.MethodId _size13923;
		 int android.view.Menu.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ContextMenu_._size13923);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._size13923);
		}
		internal static global::MonoJavaBridge.MethodId _close13924;
		 void android.view.Menu.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._close13924);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._close13924);
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey13925;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._isShortcutKey13925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._isShortcutKey13925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu13926;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu13926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu13926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu13927;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu13927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu13927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu13928;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu13928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu13928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu13929;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu13929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu13929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addIntentOptions13930;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ContextMenu_._addIntentOptions13930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addIntentOptions13930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _removeItem13931;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._removeItem13931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._removeItem13931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGroup13932;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._removeGroup13932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._removeGroup13932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupCheckable13933;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupCheckable13933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupCheckable13933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupVisible13934;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupVisible13934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupVisible13934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupEnabled13935;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupEnabled13935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupEnabled13935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasVisibleItems13936;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._hasVisibleItems13936);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._hasVisibleItems13936);
		}
		internal static global::MonoJavaBridge.MethodId _findItem13937;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._findItem13937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._findItem13937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getItem13938;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._getItem13938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._getItem13938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _performShortcut13939;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._performShortcut13939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._performShortcut13939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _performIdentifierAction13940;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._performIdentifierAction13940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._performIdentifierAction13940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQwertyMode13941;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setQwertyMode13941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setQwertyMode13941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ContextMenu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ContextMenu"));
			global::android.view.ContextMenu_._setHeaderTitle13912 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderTitle", "(I)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderTitle13913 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderIcon13914 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderIcon", "(I)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderIcon13915 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderView13916 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderView", "(Landroid/view/View;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._clearHeader13917 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "clearHeader", "()V");
			global::android.view.ContextMenu_._add13918 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add13919 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add13920 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add13921 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._clear13922 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "clear", "()V");
			global::android.view.ContextMenu_._size13923 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "size", "()I");
			global::android.view.ContextMenu_._close13924 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "close", "()V");
			global::android.view.ContextMenu_._isShortcutKey13925 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.ContextMenu_._addSubMenu13926 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu13927 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu13928 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu13929 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addIntentOptions13930 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.ContextMenu_._removeItem13931 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "removeItem", "(I)V");
			global::android.view.ContextMenu_._removeGroup13932 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "removeGroup", "(I)V");
			global::android.view.ContextMenu_._setGroupCheckable13933 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupCheckable", "(IZZ)V");
			global::android.view.ContextMenu_._setGroupVisible13934 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupVisible", "(IZ)V");
			global::android.view.ContextMenu_._setGroupEnabled13935 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupEnabled", "(IZ)V");
			global::android.view.ContextMenu_._hasVisibleItems13936 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "hasVisibleItems", "()Z");
			global::android.view.ContextMenu_._findItem13937 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._getItem13938 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._performShortcut13939 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.ContextMenu_._performIdentifierAction13940 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "performIdentifierAction", "(II)Z");
			global::android.view.ContextMenu_._setQwertyMode13941 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setQwertyMode", "(Z)V");
		}
	}
}
