namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface MenuItem 
	{ 
		bool isChecked(); 
		android.view.MenuItem setChecked(bool arg0); 
		bool isEnabled(); 
		android.view.MenuItem setEnabled(bool arg0); 
		android.content.Intent getIntent(); 
		android.view.MenuItem setVisible(bool arg0); 
		bool isVisible(); 
		android.view.MenuItem setIntent(android.content.Intent arg0); 
		android.view.MenuItem setTitle(int arg0); 
		android.view.MenuItem setTitle(java.lang.CharSequence arg0); 
		java.lang.CharSequence getTitle(); 
		int getItemId(); 
		int getGroupId(); 
		int getOrder(); 
		android.view.MenuItem setTitleCondensed(java.lang.CharSequence arg0); 
		java.lang.CharSequence getTitleCondensed(); 
		android.view.MenuItem setIcon(android.graphics.drawable.Drawable arg0); 
		android.view.MenuItem setIcon(int arg0); 
		android.graphics.drawable.Drawable getIcon(); 
		android.view.MenuItem setShortcut(char arg0, char arg1); 
		android.view.MenuItem setNumericShortcut(char arg0); 
		char getNumericShortcut(); 
		android.view.MenuItem setAlphabeticShortcut(char arg0); 
		char getAlphabeticShortcut(); 
		android.view.MenuItem setCheckable(bool arg0); 
		bool isCheckable(); 
		bool hasSubMenu(); 
		android.view.SubMenu getSubMenu(); 
		android.view.MenuItem setOnMenuItemClickListener(android.view.MenuItem_OnMenuItemClickListener arg0); 
		android.view.ContextMenu_ContextMenuInfo getMenuInfo(); 
	} 

	public partial class MenuItem_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __MenuItem.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __MenuItem : java.lang.Object, MenuItem
	{ 
		internal static global::java.lang.Class staticClass; 
		static __MenuItem() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.__MenuItem), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.__MenuItem(@__env); 
			} 
		} 
		internal __MenuItem(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChecked7905; 
		 bool android.view.MenuItem.isChecked() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return @__env.CallBooleanMethod(this, _isChecked7905); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.__MenuItem.staticClass, _isChecked7905); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChecked7906; 
		 android.view.MenuItem android.view.MenuItem.setChecked(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setChecked7906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setChecked7906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled7907; 
		 bool android.view.MenuItem.isEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return @__env.CallBooleanMethod(this, _isEnabled7907); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.__MenuItem.staticClass, _isEnabled7907); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled7908; 
		 android.view.MenuItem android.view.MenuItem.setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setEnabled7908, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setEnabled7908, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntent7909; 
		 android.content.Intent android.view.MenuItem.getIntent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _getIntent7909)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _getIntent7909)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible7910; 
		 android.view.MenuItem android.view.MenuItem.setVisible(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setVisible7910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setVisible7910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVisible7911; 
		 bool android.view.MenuItem.isVisible() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return @__env.CallBooleanMethod(this, _isVisible7911); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.__MenuItem.staticClass, _isVisible7911); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntent7912; 
		 android.view.MenuItem android.view.MenuItem.setIntent(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setIntent7912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setIntent7912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle7913; 
		 android.view.MenuItem android.view.MenuItem.setTitle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setTitle7913, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setTitle7913, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle7914; 
		 android.view.MenuItem android.view.MenuItem.setTitle(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setTitle7914, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setTitle7914, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitle7915; 
		 java.lang.CharSequence android.view.MenuItem.getTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTitle7915)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _getTitle7915)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId7916; 
		 int android.view.MenuItem.getItemId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return @__env.CallIntMethod(this, _getItemId7916); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.__MenuItem.staticClass, _getItemId7916); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupId7917; 
		 int android.view.MenuItem.getGroupId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return @__env.CallIntMethod(this, _getGroupId7917); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.__MenuItem.staticClass, _getGroupId7917); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrder7918; 
		 int android.view.MenuItem.getOrder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return @__env.CallIntMethod(this, _getOrder7918); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.__MenuItem.staticClass, _getOrder7918); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitleCondensed7919; 
		 android.view.MenuItem android.view.MenuItem.setTitleCondensed(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setTitleCondensed7919, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setTitleCondensed7919, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitleCondensed7920; 
		 java.lang.CharSequence android.view.MenuItem.getTitleCondensed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTitleCondensed7920)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _getTitleCondensed7920)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIcon7921; 
		 android.view.MenuItem android.view.MenuItem.setIcon(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setIcon7921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setIcon7921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIcon7922; 
		 android.view.MenuItem android.view.MenuItem.setIcon(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setIcon7922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setIcon7922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIcon7923; 
		 android.graphics.drawable.Drawable android.view.MenuItem.getIcon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getIcon7923)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _getIcon7923)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShortcut7924; 
		 android.view.MenuItem android.view.MenuItem.setShortcut(char arg0, char arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setShortcut7924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setShortcut7924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNumericShortcut7925; 
		 android.view.MenuItem android.view.MenuItem.setNumericShortcut(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setNumericShortcut7925, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setNumericShortcut7925, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumericShortcut7926; 
		 char android.view.MenuItem.getNumericShortcut() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return @__env.CallCharMethod(this, _getNumericShortcut7926); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.view.__MenuItem.staticClass, _getNumericShortcut7926); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlphabeticShortcut7927; 
		 android.view.MenuItem android.view.MenuItem.setAlphabeticShortcut(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setAlphabeticShortcut7927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setAlphabeticShortcut7927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlphabeticShortcut7928; 
		 char android.view.MenuItem.getAlphabeticShortcut() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return @__env.CallCharMethod(this, _getAlphabeticShortcut7928); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.view.__MenuItem.staticClass, _getAlphabeticShortcut7928); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCheckable7929; 
		 android.view.MenuItem android.view.MenuItem.setCheckable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setCheckable7929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setCheckable7929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCheckable7930; 
		 bool android.view.MenuItem.isCheckable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return @__env.CallBooleanMethod(this, _isCheckable7930); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.__MenuItem.staticClass, _isCheckable7930); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasSubMenu7931; 
		 bool android.view.MenuItem.hasSubMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return @__env.CallBooleanMethod(this, _hasSubMenu7931); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.__MenuItem.staticClass, _hasSubMenu7931); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubMenu7932; 
		 android.view.SubMenu android.view.MenuItem.getSubMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, _getSubMenu7932)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _getSubMenu7932)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnMenuItemClickListener7933; 
		 android.view.MenuItem android.view.MenuItem.setOnMenuItemClickListener(android.view.MenuItem_OnMenuItemClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, _setOnMenuItemClickListener7933, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _setOnMenuItemClickListener7933, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMenuInfo7934; 
		 android.view.ContextMenu_ContextMenuInfo android.view.MenuItem.getMenuInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallObjectMethodPtr(this, _getMenuInfo7934)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.__MenuItem.staticClass, _getMenuInfo7934)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.__MenuItem.staticClass = @__class; 
			global::android.view.__MenuItem._isChecked7905 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.isChecked", "()Z"); 
			global::android.view.__MenuItem._setChecked7906 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setChecked", "(Z)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._isEnabled7907 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.isEnabled", "()Z"); 
			global::android.view.__MenuItem._setEnabled7908 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setEnabled", "(Z)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._getIntent7909 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getIntent", "()Landroid/content/Intent;"); 
			global::android.view.__MenuItem._setVisible7910 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setVisible", "(Z)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._isVisible7911 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.isVisible", "()Z"); 
			global::android.view.__MenuItem._setIntent7912 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._setTitle7913 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setTitle", "(I)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._setTitle7914 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._getTitle7915 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getTitle", "()Ljava/lang/CharSequence;"); 
			global::android.view.__MenuItem._getItemId7916 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getItemId", "()I"); 
			global::android.view.__MenuItem._getGroupId7917 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getGroupId", "()I"); 
			global::android.view.__MenuItem._getOrder7918 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getOrder", "()I"); 
			global::android.view.__MenuItem._setTitleCondensed7919 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._getTitleCondensed7920 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getTitleCondensed", "()Ljava/lang/CharSequence;"); 
			global::android.view.__MenuItem._setIcon7921 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._setIcon7922 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setIcon", "(I)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._getIcon7923 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getIcon", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.view.__MenuItem._setShortcut7924 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setShortcut", "(CC)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._setNumericShortcut7925 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setNumericShortcut", "(C)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._getNumericShortcut7926 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getNumericShortcut", "()C"); 
			global::android.view.__MenuItem._setAlphabeticShortcut7927 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setAlphabeticShortcut", "(C)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._getAlphabeticShortcut7928 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getAlphabeticShortcut", "()C"); 
			global::android.view.__MenuItem._setCheckable7929 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setCheckable", "(Z)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._isCheckable7930 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.isCheckable", "()Z"); 
			global::android.view.__MenuItem._hasSubMenu7931 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.hasSubMenu", "()Z"); 
			global::android.view.__MenuItem._getSubMenu7932 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getSubMenu", "()Landroid/view/SubMenu;"); 
			global::android.view.__MenuItem._setOnMenuItemClickListener7933 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;"); 
			global::android.view.__MenuItem._getMenuInfo7934 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;"); 
		} 
	} 
} 
