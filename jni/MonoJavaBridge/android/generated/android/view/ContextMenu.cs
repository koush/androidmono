namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ContextMenu : Menu
	{
		global::android.view.ContextMenu setHeaderTitle(int arg0);
		global::android.view.ContextMenu setHeaderTitle(java.lang.CharSequence arg0);
		global::android.view.ContextMenu setHeaderIcon(int arg0);
		global::android.view.ContextMenu setHeaderIcon(android.graphics.drawable.Drawable arg0);
		global::android.view.ContextMenu setHeaderView(android.view.View arg0);
		void clearHeader();
	}

	public partial class ContextMenu_
	{
		public static global::java.lang.Class _class
		{
			get { return __ContextMenu.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ContextMenu : java.lang.Object, ContextMenu
	{
		internal static global::java.lang.Class staticClass;
		static __ContextMenu()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__ContextMenu), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.__ContextMenu(@__env);
			}
		}
		internal __ContextMenu(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderTitle8375;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._setHeaderTitle8375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setHeaderTitle8375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderTitle8376;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._setHeaderTitle8376, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setHeaderTitle8376, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderIcon8377;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._setHeaderIcon8377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setHeaderIcon8377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderIcon8378;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._setHeaderIcon8378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setHeaderIcon8378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderView8379;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._setHeaderView8379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setHeaderView8379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearHeader8380;
		 void android.view.ContextMenu.clearHeader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._clearHeader8380);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._clearHeader8380);
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8381;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._add8381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._add8381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8382;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._add8382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._add8382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8383;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._add8383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._add8383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8384;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._add8384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._add8384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear8385;
		 void android.view.Menu.clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._clear8385);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._clear8385);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size8386;
		 int android.view.Menu.size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__ContextMenu._size8386);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._size8386);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close8387;
		 void android.view.Menu.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._close8387);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._close8387);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShortcutKey8388;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ContextMenu._isShortcutKey8388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._isShortcutKey8388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8389;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._addSubMenu8389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._addSubMenu8389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8390;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._addSubMenu8390, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._addSubMenu8390, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8391;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._addSubMenu8391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._addSubMenu8391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8392;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._addSubMenu8392, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._addSubMenu8392, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addIntentOptions8393;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__ContextMenu._addIntentOptions8393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.view.MenuItem[], android.view.MenuItem>(@__env, arg7));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._addIntentOptions8393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.view.MenuItem[], android.view.MenuItem>(@__env, arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeItem8394;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._removeItem8394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._removeItem8394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeGroup8395;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._removeGroup8395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._removeGroup8395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupCheckable8396;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._setGroupCheckable8396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setGroupCheckable8396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupVisible8397;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._setGroupVisible8397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setGroupVisible8397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupEnabled8398;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._setGroupEnabled8398, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setGroupEnabled8398, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasVisibleItems8399;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ContextMenu._hasVisibleItems8399);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._hasVisibleItems8399);
		}
		internal static global::net.sf.jni4net.jni.MethodId _findItem8400;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._findItem8400, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._findItem8400, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem8401;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._getItem8401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._getItem8401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performShortcut8402;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ContextMenu._performShortcut8402, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._performShortcut8402, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performIdentifierAction8403;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ContextMenu._performIdentifierAction8403, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._performIdentifierAction8403, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setQwertyMode8404;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._setQwertyMode8404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setQwertyMode8404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.__ContextMenu.staticClass = @__class;
			global::android.view.__ContextMenu._setHeaderTitle8375 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.setHeaderTitle", "(I)Landroid/view/ContextMenu;");
			global::android.view.__ContextMenu._setHeaderTitle8376 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/ContextMenu;");
			global::android.view.__ContextMenu._setHeaderIcon8377 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.setHeaderIcon", "(I)Landroid/view/ContextMenu;");
			global::android.view.__ContextMenu._setHeaderIcon8378 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/ContextMenu;");
			global::android.view.__ContextMenu._setHeaderView8379 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.setHeaderView", "(Landroid/view/View;)Landroid/view/ContextMenu;");
			global::android.view.__ContextMenu._clearHeader8380 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.clearHeader", "()V");
			global::android.view.__ContextMenu._add8381 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.add", "(I)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._add8382 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._add8383 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._add8384 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._clear8385 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.clear", "()V");
			global::android.view.__ContextMenu._size8386 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.size", "()I");
			global::android.view.__ContextMenu._close8387 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.close", "()V");
			global::android.view.__ContextMenu._isShortcutKey8388 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.__ContextMenu._addSubMenu8389 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.__ContextMenu._addSubMenu8390 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.__ContextMenu._addSubMenu8391 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.__ContextMenu._addSubMenu8392 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.__ContextMenu._addIntentOptions8393 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.__ContextMenu._removeItem8394 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.removeItem", "(I)V");
			global::android.view.__ContextMenu._removeGroup8395 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.removeGroup", "(I)V");
			global::android.view.__ContextMenu._setGroupCheckable8396 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.setGroupCheckable", "(IZZ)V");
			global::android.view.__ContextMenu._setGroupVisible8397 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.setGroupVisible", "(IZ)V");
			global::android.view.__ContextMenu._setGroupEnabled8398 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.setGroupEnabled", "(IZ)V");
			global::android.view.__ContextMenu._hasVisibleItems8399 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.hasVisibleItems", "()Z");
			global::android.view.__ContextMenu._findItem8400 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._getItem8401 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._performShortcut8402 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.__ContextMenu._performIdentifierAction8403 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.performIdentifierAction", "(II)Z");
			global::android.view.__ContextMenu._setQwertyMode8404 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.setQwertyMode", "(Z)V");
		}
	}
}
