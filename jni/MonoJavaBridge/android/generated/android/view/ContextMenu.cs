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
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderTitle7701;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._setHeaderTitle7701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setHeaderTitle7701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderTitle7702;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._setHeaderTitle7702, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setHeaderTitle7702, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderIcon7703;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._setHeaderIcon7703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setHeaderIcon7703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderIcon7704;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._setHeaderIcon7704, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setHeaderIcon7704, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaderView7705;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._setHeaderView7705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setHeaderView7705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearHeader7706;
		 void android.view.ContextMenu.clearHeader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._clearHeader7706);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._clearHeader7706);
		}
		internal static global::net.sf.jni4net.jni.MethodId _add7707;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._add7707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._add7707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add7708;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._add7708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._add7708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add7709;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._add7709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._add7709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add7710;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._add7710, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._add7710, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear7711;
		 void android.view.Menu.clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._clear7711);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._clear7711);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size7712;
		 int android.view.Menu.size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__ContextMenu._size7712);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._size7712);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close7713;
		 void android.view.Menu.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._close7713);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._close7713);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShortcutKey7714;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ContextMenu._isShortcutKey7714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._isShortcutKey7714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu7715;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._addSubMenu7715, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._addSubMenu7715, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu7716;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._addSubMenu7716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._addSubMenu7716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu7717;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._addSubMenu7717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._addSubMenu7717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu7718;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._addSubMenu7718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._addSubMenu7718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addIntentOptions7719;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__ContextMenu._addIntentOptions7719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.view.MenuItem[], android.view.MenuItem>(@__env, arg7));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._addIntentOptions7719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.view.MenuItem[], android.view.MenuItem>(@__env, arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeItem7720;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._removeItem7720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._removeItem7720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeGroup7721;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._removeGroup7721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._removeGroup7721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupCheckable7722;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._setGroupCheckable7722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setGroupCheckable7722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupVisible7723;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._setGroupVisible7723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setGroupVisible7723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupEnabled7724;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._setGroupEnabled7724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setGroupEnabled7724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasVisibleItems7725;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ContextMenu._hasVisibleItems7725);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._hasVisibleItems7725);
		}
		internal static global::net.sf.jni4net.jni.MethodId _findItem7726;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._findItem7726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._findItem7726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem7727;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ContextMenu._getItem7727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._getItem7727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performShortcut7728;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ContextMenu._performShortcut7728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._performShortcut7728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performIdentifierAction7729;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ContextMenu._performIdentifierAction7729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._performIdentifierAction7729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setQwertyMode7730;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ContextMenu._setQwertyMode7730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ContextMenu.staticClass, global::android.view.__ContextMenu._setQwertyMode7730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.__ContextMenu.staticClass = @__class;
			global::android.view.__ContextMenu._setHeaderTitle7701 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.setHeaderTitle", "(I)Landroid/view/ContextMenu;");
			global::android.view.__ContextMenu._setHeaderTitle7702 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/ContextMenu;");
			global::android.view.__ContextMenu._setHeaderIcon7703 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.setHeaderIcon", "(I)Landroid/view/ContextMenu;");
			global::android.view.__ContextMenu._setHeaderIcon7704 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/ContextMenu;");
			global::android.view.__ContextMenu._setHeaderView7705 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.setHeaderView", "(Landroid/view/View;)Landroid/view/ContextMenu;");
			global::android.view.__ContextMenu._clearHeader7706 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.ContextMenu.clearHeader", "()V");
			global::android.view.__ContextMenu._add7707 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.add", "(I)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._add7708 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._add7709 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._add7710 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._clear7711 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.clear", "()V");
			global::android.view.__ContextMenu._size7712 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.size", "()I");
			global::android.view.__ContextMenu._close7713 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.close", "()V");
			global::android.view.__ContextMenu._isShortcutKey7714 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.__ContextMenu._addSubMenu7715 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.__ContextMenu._addSubMenu7716 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.__ContextMenu._addSubMenu7717 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.__ContextMenu._addSubMenu7718 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.__ContextMenu._addIntentOptions7719 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.__ContextMenu._removeItem7720 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.removeItem", "(I)V");
			global::android.view.__ContextMenu._removeGroup7721 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.removeGroup", "(I)V");
			global::android.view.__ContextMenu._setGroupCheckable7722 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.setGroupCheckable", "(IZZ)V");
			global::android.view.__ContextMenu._setGroupVisible7723 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.setGroupVisible", "(IZ)V");
			global::android.view.__ContextMenu._setGroupEnabled7724 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.setGroupEnabled", "(IZ)V");
			global::android.view.__ContextMenu._hasVisibleItems7725 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.hasVisibleItems", "()Z");
			global::android.view.__ContextMenu._findItem7726 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._getItem7727 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.__ContextMenu._performShortcut7728 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.__ContextMenu._performIdentifierAction7729 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.performIdentifierAction", "(II)Z");
			global::android.view.__ContextMenu._setQwertyMode7730 = @__env.GetMethodID(global::android.view.__ContextMenu.staticClass, "android.view.Menu.setQwertyMode", "(Z)V");
		}
	}
}
