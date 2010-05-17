namespace android.content.res 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Resources : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Resources() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.Resources), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.res.Resources(@__env); 
			} 
		} 
		protected Resources(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class NotFoundException : java.lang.RuntimeException
		{ 
			internal static global::java.lang.Class staticClass; 
			static NotFoundException() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.Resources.NotFoundException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.content.res.Resources.NotFoundException(@__env); 
				} 
			} 
			protected NotFoundException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _NotFoundException1906; 
			public NotFoundException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.res.Resources.NotFoundException.staticClass, _NotFoundException1906, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _NotFoundException1907; 
			public NotFoundException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.res.Resources.NotFoundException.staticClass, _NotFoundException1907, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.res.Resources.NotFoundException.staticClass = @__class; 
				global::android.content.res.Resources.NotFoundException._NotFoundException1906 = @__env.GetMethodID(global::android.content.res.Resources.NotFoundException.staticClass, "<init>", "()V"); 
				global::android.content.res.Resources.NotFoundException._NotFoundException1907 = @__env.GetMethodID(global::android.content.res.Resources.NotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Theme : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Theme() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.Resources.Theme), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.content.res.Resources.Theme(@__env); 
				} 
			} 
			internal Theme(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _dump1908; 
			public void dump(int arg0, java.lang.String arg1, java.lang.String arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.Resources.Theme)) 
					@__env.CallVoidMethod(this, _dump1908, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.Resources.Theme.staticClass, _dump1908, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1909; 
			public android.content.res.TypedArray obtainStyledAttributes(int[] arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.Resources.Theme)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, _obtainStyledAttributes1909, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.Theme.staticClass, _obtainStyledAttributes1909, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1910; 
			public android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.Resources.Theme)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, _obtainStyledAttributes1910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.Theme.staticClass, _obtainStyledAttributes1910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1911; 
			public android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.Resources.Theme)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, _obtainStyledAttributes1911, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.Theme.staticClass, _obtainStyledAttributes1911, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _applyStyle1912; 
			public void applyStyle(int arg0, bool arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.Resources.Theme)) 
					@__env.CallVoidMethod(this, _applyStyle1912, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.Resources.Theme.staticClass, _applyStyle1912, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setTo1913; 
			public void setTo(android.content.res.Resources.Theme arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.Resources.Theme)) 
					@__env.CallVoidMethod(this, _setTo1913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.Resources.Theme.staticClass, _setTo1913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _resolveAttribute1914; 
			public bool resolveAttribute(int arg0, android.util.TypedValue arg1, bool arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.Resources.Theme)) 
					return @__env.CallBooleanMethod(this, _resolveAttribute1914, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.content.res.Resources.Theme.staticClass, _resolveAttribute1914, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.res.Resources.Theme.staticClass = @__class; 
				global::android.content.res.Resources.Theme._dump1908 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "dump", "(ILjava/lang/String;Ljava/lang/String;)V"); 
				global::android.content.res.Resources.Theme._obtainStyledAttributes1909 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;"); 
				global::android.content.res.Resources.Theme._obtainStyledAttributes1910 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;"); 
				global::android.content.res.Resources.Theme._obtainStyledAttributes1911 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;"); 
				global::android.content.res.Resources.Theme._applyStyle1912 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "applyStyle", "(IZ)V"); 
				global::android.content.res.Resources.Theme._setTo1913 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "setTo", "(Landroid/content/res/Resources$Theme;)V"); 
				global::android.content.res.Resources.Theme._resolveAttribute1914 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "resolveAttribute", "(ILandroid/util/TypedValue;Z)Z"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean1915; 
		public virtual bool getBoolean(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return @__env.CallBooleanMethod(this, _getBoolean1915, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.Resources.staticClass, _getBoolean1915, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValue1916; 
		public virtual void getValue(int arg0, android.util.TypedValue arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				@__env.CallVoidMethod(this, _getValue1916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.Resources.staticClass, _getValue1916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValue1917; 
		public virtual void getValue(java.lang.String arg0, android.util.TypedValue arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				@__env.CallVoidMethod(this, _getValue1917, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.Resources.staticClass, _getValue1917, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInteger1918; 
		public virtual int getInteger(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return @__env.CallIntMethod(this, _getInteger1918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.Resources.staticClass, _getInteger1918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString1919; 
		public virtual java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString1919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getString1919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString1920; 
		public virtual java.lang.String getString(int arg0, java.lang.Object[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString1920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getString1920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIdentifier1921; 
		public virtual int getIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return @__env.CallIntMethod(this, _getIdentifier1921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.Resources.staticClass, _getIdentifier1921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAssets1922; 
		public virtual android.content.res.AssetManager getAssets() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallObjectMethodPtr(this, _getAssets1922)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getAssets1922)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText1923; 
		public virtual java.lang.CharSequence getText(int arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getText1923, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getText1923, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText1924; 
		public virtual java.lang.CharSequence getText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getText1924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getText1924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSystem1925; 
		public static android.content.res.Resources getSystem() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallStaticObjectMethodPtr(android.content.res.Resources.staticClass, _getSystem1925)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getQuantityText1926; 
		public virtual java.lang.CharSequence getQuantityText(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getQuantityText1926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getQuantityText1926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getQuantityString1927; 
		public virtual java.lang.String getQuantityString(int arg0, int arg1, java.lang.Object[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getQuantityString1927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getQuantityString1927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getQuantityString1928; 
		public virtual java.lang.String getQuantityString(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getQuantityString1928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getQuantityString1928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextArray1929; 
		public virtual java.lang.CharSequence[] getTextArray(int arg0) 
		{ 
			if (GetType() == typeof(android.content.res.Resources)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getTextArray1929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getTextArray1929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStringArray1930; 
		public virtual java.lang.String[] getStringArray(int arg0) 
		{ 
			if (GetType() == typeof(android.content.res.Resources)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getStringArray1930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getStringArray1930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntArray1931; 
		public virtual int[] getIntArray(int arg0) 
		{ 
			if (GetType() == typeof(android.content.res.Resources)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getIntArray1931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getIntArray1931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainTypedArray1932; 
		public virtual android.content.res.TypedArray obtainTypedArray(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, _obtainTypedArray1932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _obtainTypedArray1932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDimension1933; 
		public virtual float getDimension(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return @__env.CallFloatMethod(this, _getDimension1933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.res.Resources.staticClass, _getDimension1933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelOffset1934; 
		public virtual int getDimensionPixelOffset(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return @__env.CallIntMethod(this, _getDimensionPixelOffset1934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.Resources.staticClass, _getDimensionPixelOffset1934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelSize1935; 
		public virtual int getDimensionPixelSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return @__env.CallIntMethod(this, _getDimensionPixelSize1935, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.Resources.staticClass, _getDimensionPixelSize1935, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFraction1936; 
		public virtual float getFraction(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return @__env.CallFloatMethod(this, _getFraction1936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.res.Resources.staticClass, _getFraction1936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable1937; 
		public virtual android.graphics.drawable.Drawable getDrawable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDrawable1937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getDrawable1937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMovie1938; 
		public virtual android.graphics.Movie getMovie(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallObjectMethodPtr(this, _getMovie1938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getMovie1938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColor1939; 
		public virtual int getColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return @__env.CallIntMethod(this, _getColor1939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.Resources.staticClass, _getColor1939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColorStateList1940; 
		public virtual android.content.res.ColorStateList getColorStateList(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, _getColorStateList1940, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getColorStateList1940, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayout1941; 
		public virtual android.content.res.XmlResourceParser getLayout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, _getLayout1941, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getLayout1941, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnimation1942; 
		public virtual android.content.res.XmlResourceParser getAnimation(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, _getAnimation1942, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getAnimation1942, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getXml1943; 
		public virtual android.content.res.XmlResourceParser getXml(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, _getXml1943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getXml1943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openRawResource1944; 
		public virtual java.io.InputStream openRawResource(int arg0, android.util.TypedValue arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _openRawResource1944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _openRawResource1944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openRawResource1945; 
		public virtual java.io.InputStream openRawResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _openRawResource1945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _openRawResource1945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openRawResourceFd1946; 
		public virtual android.content.res.AssetFileDescriptor openRawResourceFd(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openRawResourceFd1946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _openRawResourceFd1946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newTheme1947; 
		public virtual android.content.res.Resources.Theme newTheme() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallObjectMethodPtr(this, _newTheme1947)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _newTheme1947)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainAttributes1948; 
		public virtual android.content.res.TypedArray obtainAttributes(android.util.AttributeSet arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, _obtainAttributes1948, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _obtainAttributes1948, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateConfiguration1949; 
		public virtual void updateConfiguration(android.content.res.Configuration arg0, android.util.DisplayMetrics arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				@__env.CallVoidMethod(this, _updateConfiguration1949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.Resources.staticClass, _updateConfiguration1949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayMetrics1950; 
		public virtual android.util.DisplayMetrics getDisplayMetrics() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.DisplayMetrics>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayMetrics1950)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.DisplayMetrics>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getDisplayMetrics1950)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConfiguration1951; 
		public virtual android.content.res.Configuration getConfiguration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Configuration>(@__env, @__env.CallObjectMethodPtr(this, _getConfiguration1951)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Configuration>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getConfiguration1951)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResourceName1952; 
		public virtual java.lang.String getResourceName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getResourceName1952, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getResourceName1952, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResourcePackageName1953; 
		public virtual java.lang.String getResourcePackageName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getResourcePackageName1953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getResourcePackageName1953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResourceTypeName1954; 
		public virtual java.lang.String getResourceTypeName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getResourceTypeName1954, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getResourceTypeName1954, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResourceEntryName1955; 
		public virtual java.lang.String getResourceEntryName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getResourceEntryName1955, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.Resources.staticClass, _getResourceEntryName1955, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseBundleExtras1956; 
		public virtual void parseBundleExtras(android.content.res.XmlResourceParser arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				@__env.CallVoidMethod(this, _parseBundleExtras1956, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.Resources.staticClass, _parseBundleExtras1956, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseBundleExtra1957; 
		public virtual void parseBundleExtra(java.lang.String arg0, android.util.AttributeSet arg1, android.os.Bundle arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				@__env.CallVoidMethod(this, _parseBundleExtra1957, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.Resources.staticClass, _parseBundleExtra1957, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flushLayoutCache1958; 
		public virtual void flushLayoutCache() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				@__env.CallVoidMethod(this, _flushLayoutCache1958); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.Resources.staticClass, _flushLayoutCache1958); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishPreloading1959; 
		public virtual void finishPreloading() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.Resources)) 
				@__env.CallVoidMethod(this, _finishPreloading1959); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.Resources.staticClass, _finishPreloading1959); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Resources1960; 
		public Resources(android.content.res.AssetManager arg0, android.util.DisplayMetrics arg1, android.content.res.Configuration arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.res.Resources.staticClass, _Resources1960, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.res.Resources.staticClass = @__class; 
			global::android.content.res.Resources._getBoolean1915 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getBoolean", "(I)Z"); 
			global::android.content.res.Resources._getValue1916 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getValue", "(ILandroid/util/TypedValue;Z)V"); 
			global::android.content.res.Resources._getValue1917 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V"); 
			global::android.content.res.Resources._getInteger1918 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getInteger", "(I)I"); 
			global::android.content.res.Resources._getString1919 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.content.res.Resources._getString1920 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;"); 
			global::android.content.res.Resources._getIdentifier1921 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.content.res.Resources._getAssets1922 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getAssets", "()Landroid/content/res/AssetManager;"); 
			global::android.content.res.Resources._getText1923 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;"); 
			global::android.content.res.Resources._getText1924 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getText", "(I)Ljava/lang/CharSequence;"); 
			global::android.content.res.Resources._getSystem1925 = @__env.GetStaticMethodID(global::android.content.res.Resources.staticClass, "getSystem", "()Landroid/content/res/Resources;"); 
			global::android.content.res.Resources._getQuantityText1926 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getQuantityText", "(II)Ljava/lang/CharSequence;"); 
			global::android.content.res.Resources._getQuantityString1927 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;"); 
			global::android.content.res.Resources._getQuantityString1928 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getQuantityString", "(II)Ljava/lang/String;"); 
			global::android.content.res.Resources._getTextArray1929 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;"); 
			global::android.content.res.Resources._getStringArray1930 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getStringArray", "(I)[Ljava/lang/String;"); 
			global::android.content.res.Resources._getIntArray1931 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getIntArray", "(I)[I"); 
			global::android.content.res.Resources._obtainTypedArray1932 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "obtainTypedArray", "(I)Landroid/content/res/TypedArray;"); 
			global::android.content.res.Resources._getDimension1933 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDimension", "(I)F"); 
			global::android.content.res.Resources._getDimensionPixelOffset1934 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDimensionPixelOffset", "(I)I"); 
			global::android.content.res.Resources._getDimensionPixelSize1935 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDimensionPixelSize", "(I)I"); 
			global::android.content.res.Resources._getFraction1936 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getFraction", "(III)F"); 
			global::android.content.res.Resources._getDrawable1937 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.res.Resources._getMovie1938 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getMovie", "(I)Landroid/graphics/Movie;"); 
			global::android.content.res.Resources._getColor1939 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getColor", "(I)I"); 
			global::android.content.res.Resources._getColorStateList1940 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;"); 
			global::android.content.res.Resources._getLayout1941 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getLayout", "(I)Landroid/content/res/XmlResourceParser;"); 
			global::android.content.res.Resources._getAnimation1942 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getAnimation", "(I)Landroid/content/res/XmlResourceParser;"); 
			global::android.content.res.Resources._getXml1943 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getXml", "(I)Landroid/content/res/XmlResourceParser;"); 
			global::android.content.res.Resources._openRawResource1944 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "openRawResource", "(ILandroid/util/TypedValue;)Ljava/io/InputStream;"); 
			global::android.content.res.Resources._openRawResource1945 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "openRawResource", "(I)Ljava/io/InputStream;"); 
			global::android.content.res.Resources._openRawResourceFd1946 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;"); 
			global::android.content.res.Resources._newTheme1947 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "newTheme", "()Landroid/content/res/Resources$Theme;"); 
			global::android.content.res.Resources._obtainAttributes1948 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;"); 
			global::android.content.res.Resources._updateConfiguration1949 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V"); 
			global::android.content.res.Resources._getDisplayMetrics1950 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDisplayMetrics", "()Landroid/util/DisplayMetrics;"); 
			global::android.content.res.Resources._getConfiguration1951 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getConfiguration", "()Landroid/content/res/Configuration;"); 
			global::android.content.res.Resources._getResourceName1952 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourceName", "(I)Ljava/lang/String;"); 
			global::android.content.res.Resources._getResourcePackageName1953 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourcePackageName", "(I)Ljava/lang/String;"); 
			global::android.content.res.Resources._getResourceTypeName1954 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourceTypeName", "(I)Ljava/lang/String;"); 
			global::android.content.res.Resources._getResourceEntryName1955 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourceEntryName", "(I)Ljava/lang/String;"); 
			global::android.content.res.Resources._parseBundleExtras1956 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "parseBundleExtras", "(Landroid/content/res/XmlResourceParser;Landroid/os/Bundle;)V"); 
			global::android.content.res.Resources._parseBundleExtra1957 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "parseBundleExtra", "(Ljava/lang/String;Landroid/util/AttributeSet;Landroid/os/Bundle;)V"); 
			global::android.content.res.Resources._flushLayoutCache1958 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "flushLayoutCache", "()V"); 
			global::android.content.res.Resources._finishPreloading1959 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "finishPreloading", "()V"); 
			global::android.content.res.Resources._Resources1960 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "<init>", "(Landroid/content/res/AssetManager;Landroid/util/DisplayMetrics;Landroid/content/res/Configuration;)V"); 
		} 
	} 
} 
