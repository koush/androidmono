namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
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

	public partial class SubMenu_
	{
		public static global::java.lang.Class _class
		{
			get { return __SubMenu.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __SubMenu : java.lang.Object, SubMenu
	{
		internal static global::java.lang.Class staticClass;
		static __SubMenu()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__SubMenu), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.__SubMenu(@__env);
			}
		}
		internal __SubMenu(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem8690;
		 global::android.view.MenuItem android.view.SubMenu.getItem() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._getItem8690));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._getItem8690));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIcon8691;
		 global::android.view.SubMenu android.view.SubMenu.setIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setIcon8691, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setIcon8691, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIcon8692;
		 global::android.view.SubMenu android.view.SubMenu.setIcon(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setIcon8692, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setIcon8692, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderTitle8693;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setHeaderTitle8693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setHeaderTitle8693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderTitle8694;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setHeaderTitle8694, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setHeaderTitle8694, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderIcon8695;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setHeaderIcon8695, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setHeaderIcon8695, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderIcon8696;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderIcon(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setHeaderIcon8696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setHeaderIcon8696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderView8697;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setHeaderView8697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setHeaderView8697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearHeader8698;
		 void android.view.SubMenu.clearHeader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._clearHeader8698);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._clearHeader8698);
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8699;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._add8699, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._add8699, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8700;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._add8700, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._add8700, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8701;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._add8701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._add8701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8702;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._add8702, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._add8702, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear8703;
		 void android.view.Menu.clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._clear8703);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._clear8703);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size8704;
		 int android.view.Menu.size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__SubMenu._size8704);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._size8704);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close8705;
		 void android.view.Menu.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._close8705);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._close8705);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShortcutKey8706;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__SubMenu._isShortcutKey8706, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._isShortcutKey8706, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8707;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._addSubMenu8707, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._addSubMenu8707, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8708;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._addSubMenu8708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._addSubMenu8708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8709;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._addSubMenu8709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._addSubMenu8709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8710;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._addSubMenu8710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._addSubMenu8710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addIntentOptions8711;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__SubMenu._addIntentOptions8711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.view.MenuItem[], android.view.MenuItem>(@__env, arg7));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._addIntentOptions8711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.view.MenuItem[], android.view.MenuItem>(@__env, arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeItem8712;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._removeItem8712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._removeItem8712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeGroup8713;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._removeGroup8713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._removeGroup8713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupCheckable8714;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._setGroupCheckable8714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setGroupCheckable8714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupVisible8715;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._setGroupVisible8715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setGroupVisible8715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupEnabled8716;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._setGroupEnabled8716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setGroupEnabled8716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasVisibleItems8717;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__SubMenu._hasVisibleItems8717);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._hasVisibleItems8717);
		}
		internal static global::net.sf.jni4net.jni.MethodId _findItem8718;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._findItem8718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._findItem8718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem8719;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._getItem8719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._getItem8719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performShortcut8720;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__SubMenu._performShortcut8720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._performShortcut8720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performIdentifierAction8721;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__SubMenu._performIdentifierAction8721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._performIdentifierAction8721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setQwertyMode8722;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._setQwertyMode8722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setQwertyMode8722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.__SubMenu.staticClass = @__class;
			global::android.view.__SubMenu._getItem8690 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.getItem", "()Landroid/view/MenuItem;");
			global::android.view.__SubMenu._setIcon8691 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setIcon8692 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setIcon", "(I)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setHeaderTitle8693 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setHeaderTitle", "(I)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setHeaderTitle8694 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setHeaderIcon8695 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setHeaderIcon8696 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setHeaderIcon", "(I)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setHeaderView8697 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setHeaderView", "(Landroid/view/View;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._clearHeader8698 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.clearHeader", "()V");
			global::android.view.__SubMenu._add8699 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.add", "(I)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._add8700 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._add8701 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._add8702 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._clear8703 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.clear", "()V");
			global::android.view.__SubMenu._size8704 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.size", "()I");
			global::android.view.__SubMenu._close8705 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.close", "()V");
			global::android.view.__SubMenu._isShortcutKey8706 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.__SubMenu._addSubMenu8707 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._addSubMenu8708 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._addSubMenu8709 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._addSubMenu8710 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._addIntentOptions8711 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.__SubMenu._removeItem8712 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.removeItem", "(I)V");
			global::android.view.__SubMenu._removeGroup8713 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.removeGroup", "(I)V");
			global::android.view.__SubMenu._setGroupCheckable8714 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.setGroupCheckable", "(IZZ)V");
			global::android.view.__SubMenu._setGroupVisible8715 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.setGroupVisible", "(IZ)V");
			global::android.view.__SubMenu._setGroupEnabled8716 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.setGroupEnabled", "(IZ)V");
			global::android.view.__SubMenu._hasVisibleItems8717 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.hasVisibleItems", "()Z");
			global::android.view.__SubMenu._findItem8718 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._getItem8719 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._performShortcut8720 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.__SubMenu._performIdentifierAction8721 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.performIdentifierAction", "(II)Z");
			global::android.view.__SubMenu._setQwertyMode8722 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.setQwertyMode", "(Z)V");
		}
	}
}
