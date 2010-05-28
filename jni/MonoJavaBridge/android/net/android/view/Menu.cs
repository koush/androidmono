namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Menu 
	{ 
		global::android.view.MenuItem add(int arg0); 
		global::android.view.MenuItem add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3); 
		global::android.view.MenuItem add(int arg0, int arg1, int arg2, int arg3); 
		global::android.view.MenuItem add(java.lang.CharSequence arg0); 
		void clear(); 
		int size(); 
		void close(); 
		bool isShortcutKey(int arg0, android.view.KeyEvent arg1); 
		global::android.view.SubMenu addSubMenu(java.lang.CharSequence arg0); 
		global::android.view.SubMenu addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3); 
		global::android.view.SubMenu addSubMenu(int arg0); 
		global::android.view.SubMenu addSubMenu(int arg0, int arg1, int arg2, int arg3); 
		int addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7); 
		void removeItem(int arg0); 
		void removeGroup(int arg0); 
		void setGroupCheckable(int arg0, bool arg1, bool arg2); 
		void setGroupVisible(int arg0, bool arg1); 
		void setGroupEnabled(int arg0, bool arg1); 
		bool hasVisibleItems(); 
		global::android.view.MenuItem findItem(int arg0); 
		global::android.view.MenuItem getItem(int arg0); 
		bool performShortcut(int arg0, android.view.KeyEvent arg1, int arg2); 
		bool performIdentifierAction(int arg0, int arg1); 
		void setQwertyMode(bool arg0); 
	} 

	public partial class Menu_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Menu.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Menu : java.lang.Object, Menu
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Menu() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__Menu), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.__Menu(@__env); 
			} 
		} 
		internal __Menu(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add7878; 
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__Menu._add7878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._add7878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add7879; 
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__Menu._add7879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._add7879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add7880; 
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__Menu._add7880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._add7880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add7881; 
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__Menu._add7881, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._add7881, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear7882; 
		 void android.view.Menu.clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				@__env.CallVoidMethod(this, global::android.view.__Menu._clear7882); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._clear7882); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size7883; 
		 int android.view.Menu.size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return @__env.CallIntMethod(this, global::android.view.__Menu._size7883); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._size7883); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close7884; 
		 void android.view.Menu.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				@__env.CallVoidMethod(this, global::android.view.__Menu._close7884); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._close7884); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShortcutKey7885; 
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return @__env.CallBooleanMethod(this, global::android.view.__Menu._isShortcutKey7885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._isShortcutKey7885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu7886; 
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__Menu._addSubMenu7886, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._addSubMenu7886, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu7887; 
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__Menu._addSubMenu7887, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._addSubMenu7887, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu7888; 
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__Menu._addSubMenu7888, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._addSubMenu7888, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSubMenu7889; 
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__Menu._addSubMenu7889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._addSubMenu7889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addIntentOptions7890; 
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return @__env.CallIntMethod(this, global::android.view.__Menu._addIntentOptions7890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.view.MenuItem[], android.view.MenuItem>(@__env, arg7)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._addIntentOptions7890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.view.MenuItem[], android.view.MenuItem>(@__env, arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeItem7891; 
		 void android.view.Menu.removeItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				@__env.CallVoidMethod(this, global::android.view.__Menu._removeItem7891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._removeItem7891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeGroup7892; 
		 void android.view.Menu.removeGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				@__env.CallVoidMethod(this, global::android.view.__Menu._removeGroup7892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._removeGroup7892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGroupCheckable7893; 
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				@__env.CallVoidMethod(this, global::android.view.__Menu._setGroupCheckable7893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._setGroupCheckable7893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGroupVisible7894; 
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				@__env.CallVoidMethod(this, global::android.view.__Menu._setGroupVisible7894, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._setGroupVisible7894, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGroupEnabled7895; 
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				@__env.CallVoidMethod(this, global::android.view.__Menu._setGroupEnabled7895, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._setGroupEnabled7895, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasVisibleItems7896; 
		 bool android.view.Menu.hasVisibleItems() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return @__env.CallBooleanMethod(this, global::android.view.__Menu._hasVisibleItems7896); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._hasVisibleItems7896); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findItem7897; 
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__Menu._findItem7897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._findItem7897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem7898; 
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__Menu._getItem7898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._getItem7898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performShortcut7899; 
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return @__env.CallBooleanMethod(this, global::android.view.__Menu._performShortcut7899, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._performShortcut7899, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performIdentifierAction7900; 
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				return @__env.CallBooleanMethod(this, global::android.view.__Menu._performIdentifierAction7900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._performIdentifierAction7900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setQwertyMode7901; 
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__Menu)) 
				@__env.CallVoidMethod(this, global::android.view.__Menu._setQwertyMode7901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__Menu.staticClass, global::android.view.__Menu._setQwertyMode7901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.__Menu.staticClass = @__class; 
			global::android.view.__Menu._add7878 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.add", "(I)Landroid/view/MenuItem;"); 
			global::android.view.__Menu._add7879 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;"); 
			global::android.view.__Menu._add7880 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.add", "(IIII)Landroid/view/MenuItem;"); 
			global::android.view.__Menu._add7881 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;"); 
			global::android.view.__Menu._clear7882 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.clear", "()V"); 
			global::android.view.__Menu._size7883 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.size", "()I"); 
			global::android.view.__Menu._close7884 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.close", "()V"); 
			global::android.view.__Menu._isShortcutKey7885 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.isShortcutKey", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.__Menu._addSubMenu7886 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;"); 
			global::android.view.__Menu._addSubMenu7887 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;"); 
			global::android.view.__Menu._addSubMenu7888 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.addSubMenu", "(I)Landroid/view/SubMenu;"); 
			global::android.view.__Menu._addSubMenu7889 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.addSubMenu", "(IIII)Landroid/view/SubMenu;"); 
			global::android.view.__Menu._addIntentOptions7890 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I"); 
			global::android.view.__Menu._removeItem7891 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.removeItem", "(I)V"); 
			global::android.view.__Menu._removeGroup7892 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.removeGroup", "(I)V"); 
			global::android.view.__Menu._setGroupCheckable7893 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.setGroupCheckable", "(IZZ)V"); 
			global::android.view.__Menu._setGroupVisible7894 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.setGroupVisible", "(IZ)V"); 
			global::android.view.__Menu._setGroupEnabled7895 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.setGroupEnabled", "(IZ)V"); 
			global::android.view.__Menu._hasVisibleItems7896 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.hasVisibleItems", "()Z"); 
			global::android.view.__Menu._findItem7897 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.findItem", "(I)Landroid/view/MenuItem;"); 
			global::android.view.__Menu._getItem7898 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.getItem", "(I)Landroid/view/MenuItem;"); 
			global::android.view.__Menu._performShortcut7899 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.performShortcut", "(ILandroid/view/KeyEvent;I)Z"); 
			global::android.view.__Menu._performIdentifierAction7900 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.performIdentifierAction", "(II)Z"); 
			global::android.view.__Menu._setQwertyMode7901 = @__env.GetMethodID(global::android.view.__Menu.staticClass, "android.view.Menu.setQwertyMode", "(Z)V"); 
		} 
	} 
} 
