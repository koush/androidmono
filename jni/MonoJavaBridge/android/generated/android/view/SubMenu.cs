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
		internal static global::net.sf.jni4net.jni.MethodId _getItem7995;
		 global::android.view.MenuItem android.view.SubMenu.getItem() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._getItem7995));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._getItem7995));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIcon7996;
		 global::android.view.SubMenu android.view.SubMenu.setIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setIcon7996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setIcon7996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIcon7997;
		 global::android.view.SubMenu android.view.SubMenu.setIcon(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setIcon7997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setIcon7997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderTitle7998;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setHeaderTitle7998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setHeaderTitle7998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderTitle7999;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setHeaderTitle7999, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setHeaderTitle7999, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderIcon8000;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setHeaderIcon8000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setHeaderIcon8000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderIcon8001;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderIcon(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setHeaderIcon8001, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setHeaderIcon8001, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderView8002;
		 global::android.view.SubMenu android.view.SubMenu.setHeaderView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._setHeaderView8002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setHeaderView8002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearHeader8003;
		 void android.view.SubMenu.clearHeader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._clearHeader8003);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._clearHeader8003);
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8004;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._add8004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._add8004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8005;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._add8005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._add8005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8006;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._add8006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._add8006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add8007;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._add8007, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._add8007, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear8008;
		 void android.view.Menu.clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._clear8008);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._clear8008);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size8009;
		 int android.view.Menu.size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__SubMenu._size8009);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._size8009);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close8010;
		 void android.view.Menu.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._close8010);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._close8010);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShortcutKey8011;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__SubMenu._isShortcutKey8011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._isShortcutKey8011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8012;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._addSubMenu8012, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._addSubMenu8012, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8013;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._addSubMenu8013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._addSubMenu8013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8014;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._addSubMenu8014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._addSubMenu8014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu8015;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._addSubMenu8015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._addSubMenu8015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addIntentOptions8016;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__SubMenu._addIntentOptions8016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.view.MenuItem[], android.view.MenuItem>(@__env, arg7));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._addIntentOptions8016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.view.MenuItem[], android.view.MenuItem>(@__env, arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeItem8017;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._removeItem8017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._removeItem8017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeGroup8018;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._removeGroup8018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._removeGroup8018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupCheckable8019;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._setGroupCheckable8019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setGroupCheckable8019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupVisible8020;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._setGroupVisible8020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setGroupVisible8020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupEnabled8021;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._setGroupEnabled8021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setGroupEnabled8021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasVisibleItems8022;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__SubMenu._hasVisibleItems8022);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._hasVisibleItems8022);
		}
		internal static global::net.sf.jni4net.jni.MethodId _findItem8023;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._findItem8023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._findItem8023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem8024;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SubMenu._getItem8024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._getItem8024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performShortcut8025;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__SubMenu._performShortcut8025, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._performShortcut8025, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performIdentifierAction8026;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__SubMenu._performIdentifierAction8026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._performIdentifierAction8026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setQwertyMode8027;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__SubMenu._setQwertyMode8027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SubMenu.staticClass, global::android.view.__SubMenu._setQwertyMode8027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.__SubMenu.staticClass = @__class;
			global::android.view.__SubMenu._getItem7995 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.getItem", "()Landroid/view/MenuItem;");
			global::android.view.__SubMenu._setIcon7996 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setIcon7997 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setIcon", "(I)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setHeaderTitle7998 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setHeaderTitle", "(I)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setHeaderTitle7999 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setHeaderIcon8000 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setHeaderIcon8001 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setHeaderIcon", "(I)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._setHeaderView8002 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.setHeaderView", "(Landroid/view/View;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._clearHeader8003 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.SubMenu.clearHeader", "()V");
			global::android.view.__SubMenu._add8004 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.add", "(I)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._add8005 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._add8006 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._add8007 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._clear8008 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.clear", "()V");
			global::android.view.__SubMenu._size8009 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.size", "()I");
			global::android.view.__SubMenu._close8010 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.close", "()V");
			global::android.view.__SubMenu._isShortcutKey8011 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.__SubMenu._addSubMenu8012 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._addSubMenu8013 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._addSubMenu8014 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._addSubMenu8015 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.__SubMenu._addIntentOptions8016 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.__SubMenu._removeItem8017 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.removeItem", "(I)V");
			global::android.view.__SubMenu._removeGroup8018 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.removeGroup", "(I)V");
			global::android.view.__SubMenu._setGroupCheckable8019 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.setGroupCheckable", "(IZZ)V");
			global::android.view.__SubMenu._setGroupVisible8020 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.setGroupVisible", "(IZ)V");
			global::android.view.__SubMenu._setGroupEnabled8021 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.setGroupEnabled", "(IZ)V");
			global::android.view.__SubMenu._hasVisibleItems8022 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.hasVisibleItems", "()Z");
			global::android.view.__SubMenu._findItem8023 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._getItem8024 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.__SubMenu._performShortcut8025 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.__SubMenu._performIdentifierAction8026 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.performIdentifierAction", "(II)Z");
			global::android.view.__SubMenu._setQwertyMode8027 = @__env.GetMethodID(global::android.view.__SubMenu.staticClass, "android.view.Menu.setQwertyMode", "(Z)V");
		}
	}
}
