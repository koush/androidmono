namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.Menu_))]
	public interface Menu  : global::MonoJavaBridge.IJavaObject 
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

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.Menu))]
	public sealed partial class Menu_ : java.lang.Object, Menu
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Menu_()
		{
			InitJNI();
		}
		internal Menu_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add9406;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._add9406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._add9406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add9407;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._add9407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._add9407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add9408;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._add9408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._add9408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add9409;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._add9409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._add9409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _clear9410;
		 void android.view.Menu.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._clear9410);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._clear9410);
		}
		internal static global::MonoJavaBridge.MethodId _size9411;
		 int android.view.Menu.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Menu_._size9411);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._size9411);
		}
		internal static global::MonoJavaBridge.MethodId _close9412;
		 void android.view.Menu.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._close9412);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._close9412);
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey9413;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Menu_._isShortcutKey9413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._isShortcutKey9413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9414;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._addSubMenu9414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._addSubMenu9414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9415;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._addSubMenu9415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._addSubMenu9415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9416;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._addSubMenu9416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._addSubMenu9416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu9417;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._addSubMenu9417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._addSubMenu9417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addIntentOptions9418;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Menu_._addIntentOptions9418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._addIntentOptions9418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _removeItem9419;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._removeItem9419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._removeItem9419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGroup9420;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._removeGroup9420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._removeGroup9420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupCheckable9421;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._setGroupCheckable9421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._setGroupCheckable9421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupVisible9422;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._setGroupVisible9422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._setGroupVisible9422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupEnabled9423;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._setGroupEnabled9423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._setGroupEnabled9423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasVisibleItems9424;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Menu_._hasVisibleItems9424);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._hasVisibleItems9424);
		}
		internal static global::MonoJavaBridge.MethodId _findItem9425;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._findItem9425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._findItem9425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getItem9426;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Menu_._getItem9426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._getItem9426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _performShortcut9427;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Menu_._performShortcut9427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._performShortcut9427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _performIdentifierAction9428;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Menu_._performIdentifierAction9428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._performIdentifierAction9428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQwertyMode9429;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Menu_._setQwertyMode9429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Menu_.staticClass, global::android.view.Menu_._setQwertyMode9429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Menu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Menu"));
			global::android.view.Menu_._add9406 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "add", "(I)Landroid/view/MenuItem;");
			global::android.view.Menu_._add9407 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.Menu_._add9408 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.Menu_._add9409 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.Menu_._clear9410 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "clear", "()V");
			global::android.view.Menu_._size9411 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "size", "()I");
			global::android.view.Menu_._close9412 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "close", "()V");
			global::android.view.Menu_._isShortcutKey9413 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.Menu_._addSubMenu9414 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.Menu_._addSubMenu9415 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.Menu_._addSubMenu9416 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.Menu_._addSubMenu9417 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.Menu_._addIntentOptions9418 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.Menu_._removeItem9419 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "removeItem", "(I)V");
			global::android.view.Menu_._removeGroup9420 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "removeGroup", "(I)V");
			global::android.view.Menu_._setGroupCheckable9421 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "setGroupCheckable", "(IZZ)V");
			global::android.view.Menu_._setGroupVisible9422 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "setGroupVisible", "(IZ)V");
			global::android.view.Menu_._setGroupEnabled9423 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "setGroupEnabled", "(IZ)V");
			global::android.view.Menu_._hasVisibleItems9424 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "hasVisibleItems", "()Z");
			global::android.view.Menu_._findItem9425 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.Menu_._getItem9426 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.Menu_._performShortcut9427 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.Menu_._performIdentifierAction9428 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "performIdentifierAction", "(II)Z");
			global::android.view.Menu_._setQwertyMode9429 = @__env.GetMethodIDNoThrow(global::android.view.Menu_.staticClass, "setQwertyMode", "(Z)V");
		}
	}
}
