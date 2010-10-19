namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ContextMenu_))]
	public interface ContextMenu : Menu
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
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle9225;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderTitle9225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderTitle9225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle9226;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderTitle9226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderTitle9226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon9227;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderIcon9227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderIcon9227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon9228;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderIcon9228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderIcon9228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderView9229;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderView9229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderView9229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _clearHeader9230;
		 void android.view.ContextMenu.clearHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._clearHeader9230);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._clearHeader9230);
		}
		internal static global::MonoJavaBridge.MethodId _add9231;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add9231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add9231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add9232;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add9232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add9232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add9233;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add9233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add9233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add9234;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add9234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add9234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _clear9235;
		 void android.view.Menu.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._clear9235);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._clear9235);
		}
		internal static global::MonoJavaBridge.MethodId _size9236;
		 int android.view.Menu.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ContextMenu_._size9236);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._size9236);
		}
		internal static global::MonoJavaBridge.MethodId _close9237;
		 void android.view.Menu.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._close9237);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._close9237);
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey9238;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._isShortcutKey9238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._isShortcutKey9238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9239;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu9239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu9239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9240;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu9240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu9240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9241;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu9241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu9241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9242;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu9242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu9242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addIntentOptions9243;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ContextMenu_._addIntentOptions9243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addIntentOptions9243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _removeItem9244;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._removeItem9244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._removeItem9244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGroup9245;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._removeGroup9245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._removeGroup9245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupCheckable9246;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupCheckable9246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupCheckable9246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupVisible9247;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupVisible9247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupVisible9247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupEnabled9248;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupEnabled9248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupEnabled9248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasVisibleItems9249;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._hasVisibleItems9249);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._hasVisibleItems9249);
		}
		internal static global::MonoJavaBridge.MethodId _findItem9250;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._findItem9250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._findItem9250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getItem9251;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._getItem9251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._getItem9251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _performShortcut9252;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._performShortcut9252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._performShortcut9252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _performIdentifierAction9253;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._performIdentifierAction9253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._performIdentifierAction9253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQwertyMode9254;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setQwertyMode9254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setQwertyMode9254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ContextMenu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ContextMenu"));
			global::android.view.ContextMenu_._setHeaderTitle9225 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderTitle", "(I)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderTitle9226 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderIcon9227 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderIcon", "(I)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderIcon9228 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderView9229 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderView", "(Landroid/view/View;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._clearHeader9230 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "clearHeader", "()V");
			global::android.view.ContextMenu_._add9231 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add9232 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add9233 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add9234 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._clear9235 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "clear", "()V");
			global::android.view.ContextMenu_._size9236 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "size", "()I");
			global::android.view.ContextMenu_._close9237 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "close", "()V");
			global::android.view.ContextMenu_._isShortcutKey9238 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.ContextMenu_._addSubMenu9239 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu9240 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu9241 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu9242 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addIntentOptions9243 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.ContextMenu_._removeItem9244 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "removeItem", "(I)V");
			global::android.view.ContextMenu_._removeGroup9245 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "removeGroup", "(I)V");
			global::android.view.ContextMenu_._setGroupCheckable9246 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupCheckable", "(IZZ)V");
			global::android.view.ContextMenu_._setGroupVisible9247 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupVisible", "(IZ)V");
			global::android.view.ContextMenu_._setGroupEnabled9248 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupEnabled", "(IZ)V");
			global::android.view.ContextMenu_._hasVisibleItems9249 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "hasVisibleItems", "()Z");
			global::android.view.ContextMenu_._findItem9250 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._getItem9251 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._performShortcut9252 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.ContextMenu_._performIdentifierAction9253 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "performIdentifierAction", "(II)Z");
			global::android.view.ContextMenu_._setQwertyMode9254 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setQwertyMode", "(Z)V");
		}
	}
}
