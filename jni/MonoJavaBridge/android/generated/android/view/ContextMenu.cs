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
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle8679;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderTitle8679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderTitle8679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle8680;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderTitle8680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderTitle8680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon8681;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderIcon8681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderIcon8681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon8682;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderIcon8682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderIcon8682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderView8683;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderView8683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderView8683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _clearHeader8684;
		 void android.view.ContextMenu.clearHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._clearHeader8684);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._clearHeader8684);
		}
		internal static global::MonoJavaBridge.MethodId _add8685;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add8685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add8685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add8686;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add8686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add8686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add8687;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add8687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add8687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add8688;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add8688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add8688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _clear8689;
		 void android.view.Menu.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._clear8689);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._clear8689);
		}
		internal static global::MonoJavaBridge.MethodId _size8690;
		 int android.view.Menu.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ContextMenu_._size8690);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._size8690);
		}
		internal static global::MonoJavaBridge.MethodId _close8691;
		 void android.view.Menu.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._close8691);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._close8691);
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey8692;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._isShortcutKey8692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._isShortcutKey8692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu8693;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu8693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu8693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu8694;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu8694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu8694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu8695;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu8695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu8695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu8696;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu8696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu8696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addIntentOptions8697;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ContextMenu_._addIntentOptions8697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addIntentOptions8697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _removeItem8698;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._removeItem8698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._removeItem8698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGroup8699;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._removeGroup8699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._removeGroup8699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupCheckable8700;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupCheckable8700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupCheckable8700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupVisible8701;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupVisible8701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupVisible8701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupEnabled8702;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupEnabled8702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupEnabled8702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasVisibleItems8703;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._hasVisibleItems8703);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._hasVisibleItems8703);
		}
		internal static global::MonoJavaBridge.MethodId _findItem8704;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._findItem8704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._findItem8704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getItem8705;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._getItem8705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._getItem8705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _performShortcut8706;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._performShortcut8706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._performShortcut8706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _performIdentifierAction8707;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._performIdentifierAction8707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._performIdentifierAction8707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQwertyMode8708;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setQwertyMode8708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setQwertyMode8708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ContextMenu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ContextMenu"));
			global::android.view.ContextMenu_._setHeaderTitle8679 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderTitle", "(I)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderTitle8680 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderIcon8681 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderIcon", "(I)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderIcon8682 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderView8683 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderView", "(Landroid/view/View;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._clearHeader8684 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "clearHeader", "()V");
			global::android.view.ContextMenu_._add8685 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add8686 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add8687 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add8688 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._clear8689 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "clear", "()V");
			global::android.view.ContextMenu_._size8690 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "size", "()I");
			global::android.view.ContextMenu_._close8691 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "close", "()V");
			global::android.view.ContextMenu_._isShortcutKey8692 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.ContextMenu_._addSubMenu8693 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu8694 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu8695 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu8696 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addIntentOptions8697 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.ContextMenu_._removeItem8698 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "removeItem", "(I)V");
			global::android.view.ContextMenu_._removeGroup8699 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "removeGroup", "(I)V");
			global::android.view.ContextMenu_._setGroupCheckable8700 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupCheckable", "(IZZ)V");
			global::android.view.ContextMenu_._setGroupVisible8701 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupVisible", "(IZ)V");
			global::android.view.ContextMenu_._setGroupEnabled8702 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupEnabled", "(IZ)V");
			global::android.view.ContextMenu_._hasVisibleItems8703 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "hasVisibleItems", "()Z");
			global::android.view.ContextMenu_._findItem8704 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._getItem8705 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._performShortcut8706 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.ContextMenu_._performIdentifierAction8707 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "performIdentifierAction", "(II)Z");
			global::android.view.ContextMenu_._setQwertyMode8708 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setQwertyMode", "(Z)V");
		}
	}
}
