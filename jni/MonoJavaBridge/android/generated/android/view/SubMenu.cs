namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.SubMenu_))]
	public interface SubMenu : Menu
	{
		global::android.view.MenuItem getItem();
		global::android.view.SubMenu setIcon(android.graphics.drawable.Drawable arg0);
		global::android.view.SubMenu setIcon(int arg0);
		global::android.view.SubMenu setHeaderTitle(int arg0);
		global::android.view.SubMenu setHeaderTitle(java.lang.CharSequence arg0);
		global::android.view.SubMenu setHeaderIcon(android.graphics.drawable.Drawable arg0);
		global::android.view.SubMenu setHeaderIcon(int arg0);
		global::android.view.SubMenu setHeaderView(android.view.View arg0);
		void clearHeader();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.SubMenu))]
	public sealed partial class SubMenu_ : java.lang.Object, SubMenu
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SubMenu_()
		{
			InitJNI();
		}
		internal SubMenu_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getItem9544;
		 global::android.view.MenuItem android.view.SubMenu.getItem() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._getItem9544)) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._getItem9544)) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon9545;
		 global::android.view.SubMenu android.view.SubMenu.setIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setIcon9545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setIcon9545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon9546;
		 global::android.view.SubMenu android.view.SubMenu.setIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setIcon9546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setIcon9546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle9547;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setHeaderTitle9547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setHeaderTitle9547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle9548;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setHeaderTitle9548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setHeaderTitle9548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon9549;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setHeaderIcon9549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setHeaderIcon9549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon9550;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setHeaderIcon9550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setHeaderIcon9550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderView9551;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setHeaderView9551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setHeaderView9551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _clearHeader9552;
		 void android.view.SubMenu.clearHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._clearHeader9552);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._clearHeader9552);
		}
		internal static global::MonoJavaBridge.MethodId _add9553;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._add9553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._add9553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add9554;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._add9554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._add9554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add9555;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._add9555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._add9555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add9556;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._add9556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._add9556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _clear9557;
		 void android.view.Menu.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._clear9557);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._clear9557);
		}
		internal static global::MonoJavaBridge.MethodId _size9558;
		 int android.view.Menu.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.SubMenu_._size9558);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._size9558);
		}
		internal static global::MonoJavaBridge.MethodId _close9559;
		 void android.view.Menu.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._close9559);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._close9559);
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey9560;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SubMenu_._isShortcutKey9560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._isShortcutKey9560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9561;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._addSubMenu9561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._addSubMenu9561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9562;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._addSubMenu9562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._addSubMenu9562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9563;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._addSubMenu9563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._addSubMenu9563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9564;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._addSubMenu9564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._addSubMenu9564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addIntentOptions9565;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.SubMenu_._addIntentOptions9565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._addIntentOptions9565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _removeItem9566;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._removeItem9566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._removeItem9566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGroup9567;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._removeGroup9567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._removeGroup9567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupCheckable9568;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._setGroupCheckable9568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setGroupCheckable9568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupVisible9569;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._setGroupVisible9569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setGroupVisible9569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupEnabled9570;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._setGroupEnabled9570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setGroupEnabled9570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasVisibleItems9571;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SubMenu_._hasVisibleItems9571);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._hasVisibleItems9571);
		}
		internal static global::MonoJavaBridge.MethodId _findItem9572;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._findItem9572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._findItem9572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getItem9573;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._getItem9573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._getItem9573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _performShortcut9574;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SubMenu_._performShortcut9574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._performShortcut9574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _performIdentifierAction9575;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SubMenu_._performIdentifierAction9575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._performIdentifierAction9575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQwertyMode9576;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._setQwertyMode9576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setQwertyMode9576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SubMenu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SubMenu"));
			global::android.view.SubMenu_._getItem9544 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "getItem", "()Landroid/view/MenuItem;");
			global::android.view.SubMenu_._setIcon9545 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setIcon9546 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setIcon", "(I)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setHeaderTitle9547 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setHeaderTitle", "(I)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setHeaderTitle9548 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setHeaderIcon9549 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setHeaderIcon9550 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setHeaderIcon", "(I)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setHeaderView9551 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setHeaderView", "(Landroid/view/View;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._clearHeader9552 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "clearHeader", "()V");
			global::android.view.SubMenu_._add9553 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "add", "(I)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._add9554 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._add9555 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._add9556 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._clear9557 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "clear", "()V");
			global::android.view.SubMenu_._size9558 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "size", "()I");
			global::android.view.SubMenu_._close9559 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "close", "()V");
			global::android.view.SubMenu_._isShortcutKey9560 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.SubMenu_._addSubMenu9561 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._addSubMenu9562 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._addSubMenu9563 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._addSubMenu9564 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._addIntentOptions9565 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.SubMenu_._removeItem9566 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "removeItem", "(I)V");
			global::android.view.SubMenu_._removeGroup9567 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "removeGroup", "(I)V");
			global::android.view.SubMenu_._setGroupCheckable9568 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setGroupCheckable", "(IZZ)V");
			global::android.view.SubMenu_._setGroupVisible9569 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setGroupVisible", "(IZ)V");
			global::android.view.SubMenu_._setGroupEnabled9570 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setGroupEnabled", "(IZ)V");
			global::android.view.SubMenu_._hasVisibleItems9571 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "hasVisibleItems", "()Z");
			global::android.view.SubMenu_._findItem9572 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._getItem9573 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._performShortcut9574 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.SubMenu_._performIdentifierAction9575 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "performIdentifierAction", "(II)Z");
			global::android.view.SubMenu_._setQwertyMode9576 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setQwertyMode", "(Z)V");
		}
	}
}
