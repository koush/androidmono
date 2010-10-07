namespace android.content.res
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Resources : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Resources()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.Resources), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.Resources.NotFoundException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _NotFoundException2132;
			public NotFoundException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.res.Resources.NotFoundException.staticClass, global::android.content.res.Resources.NotFoundException._NotFoundException2132, this);
			}
			internal static global::net.sf.jni4net.jni.MethodId _NotFoundException2133;
			public NotFoundException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.res.Resources.NotFoundException.staticClass, global::android.content.res.Resources.NotFoundException._NotFoundException2133, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.res.Resources.NotFoundException.staticClass = @__class;
				global::android.content.res.Resources.NotFoundException._NotFoundException2132 = @__env.GetMethodID(global::android.content.res.Resources.NotFoundException.staticClass, "<init>", "()V");
				global::android.content.res.Resources.NotFoundException._NotFoundException2133 = @__env.GetMethodID(global::android.content.res.Resources.NotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Theme : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Theme()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.Resources.Theme), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _dump2134;
			public void dump(int arg0, java.lang.String arg1, java.lang.String arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.Resources.Theme._dump2134, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._dump2134, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes2135;
			public global::android.content.res.TypedArray obtainStyledAttributes(int[] arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources.Theme._obtainStyledAttributes2135, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._obtainStyledAttributes2135, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes2136;
			public global::android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources.Theme._obtainStyledAttributes2136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._obtainStyledAttributes2136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes2137;
			public global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources.Theme._obtainStyledAttributes2137, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._obtainStyledAttributes2137, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setTo2138;
			public void setTo(android.content.res.Resources.Theme arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.Resources.Theme._setTo2138, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._setTo2138, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _applyStyle2139;
			public void applyStyle(int arg0, bool arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.Resources.Theme._applyStyle2139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._applyStyle2139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _resolveAttribute2140;
			public bool resolveAttribute(int arg0, android.util.TypedValue arg1, bool arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.content.res.Resources.Theme._resolveAttribute2140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._resolveAttribute2140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.res.Resources.Theme.staticClass = @__class;
				global::android.content.res.Resources.Theme._dump2134 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "dump", "(ILjava/lang/String;Ljava/lang/String;)V");
				global::android.content.res.Resources.Theme._obtainStyledAttributes2135 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;");
				global::android.content.res.Resources.Theme._obtainStyledAttributes2136 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;");
				global::android.content.res.Resources.Theme._obtainStyledAttributes2137 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;");
				global::android.content.res.Resources.Theme._setTo2138 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "setTo", "(Landroid/content/res/Resources$Theme;)V");
				global::android.content.res.Resources.Theme._applyStyle2139 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "applyStyle", "(IZ)V");
				global::android.content.res.Resources.Theme._resolveAttribute2140 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "resolveAttribute", "(ILandroid/util/TypedValue;Z)Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean2141;
		public virtual bool getBoolean(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.Resources._getBoolean2141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getBoolean2141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue2142;
		public virtual void getValue(int arg0, android.util.TypedValue arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._getValue2142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getValue2142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue2143;
		public virtual void getValue(java.lang.String arg0, android.util.TypedValue arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._getValue2143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getValue2143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInteger2144;
		public virtual int getInteger(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Resources._getInteger2144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getInteger2144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString2145;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getString2145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getString2145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString2146;
		public virtual global::java.lang.String getString(int arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getString2146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getString2146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIdentifier2147;
		public virtual int getIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Resources._getIdentifier2147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getIdentifier2147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAssets2148;
		public virtual global::android.content.res.AssetManager getAssets() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getAssets2148));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getAssets2148));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText2149;
		public virtual global::java.lang.CharSequence getText(int arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getText2149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getText2149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		public java.lang.CharSequence getText(int arg0, string arg1)
		{
			return getText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText2150;
		public virtual global::java.lang.CharSequence getText(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getText2150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getText2150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSystem2151;
		public static global::android.content.res.Resources getSystem() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallStaticObjectMethodPtr(android.content.res.Resources.staticClass, global::android.content.res.Resources._getSystem2151));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getQuantityText2152;
		public virtual global::java.lang.CharSequence getQuantityText(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getQuantityText2152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getQuantityText2152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getQuantityString2153;
		public virtual global::java.lang.String getQuantityString(int arg0, int arg1, java.lang.Object[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getQuantityString2153, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getQuantityString2153, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getQuantityString2154;
		public virtual global::java.lang.String getQuantityString(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getQuantityString2154, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getQuantityString2154, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextArray2155;
		public virtual global::java.lang.CharSequence[] getTextArray(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getTextArray2155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getTextArray2155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStringArray2156;
		public virtual global::java.lang.String[] getStringArray(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getStringArray2156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getStringArray2156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntArray2157;
		public virtual int[] getIntArray(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getIntArray2157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getIntArray2157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainTypedArray2158;
		public virtual global::android.content.res.TypedArray obtainTypedArray(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._obtainTypedArray2158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._obtainTypedArray2158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDimension2159;
		public virtual float getDimension(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.content.res.Resources._getDimension2159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDimension2159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelOffset2160;
		public virtual int getDimensionPixelOffset(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Resources._getDimensionPixelOffset2160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDimensionPixelOffset2160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelSize2161;
		public virtual int getDimensionPixelSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Resources._getDimensionPixelSize2161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDimensionPixelSize2161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFraction2162;
		public virtual float getFraction(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.content.res.Resources._getFraction2162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getFraction2162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable2163;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getDrawable2163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDrawable2163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMovie2164;
		public virtual global::android.graphics.Movie getMovie(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getMovie2164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getMovie2164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColor2165;
		public virtual int getColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Resources._getColor2165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getColor2165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColorStateList2166;
		public virtual global::android.content.res.ColorStateList getColorStateList(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getColorStateList2166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getColorStateList2166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayout2167;
		public virtual global::android.content.res.XmlResourceParser getLayout(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getLayout2167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getLayout2167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnimation2168;
		public virtual global::android.content.res.XmlResourceParser getAnimation(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getAnimation2168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getAnimation2168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getXml2169;
		public virtual global::android.content.res.XmlResourceParser getXml(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getXml2169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getXml2169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openRawResource2170;
		public virtual global::java.io.InputStream openRawResource(int arg0, android.util.TypedValue arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._openRawResource2170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._openRawResource2170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openRawResource2171;
		public virtual global::java.io.InputStream openRawResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._openRawResource2171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._openRawResource2171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openRawResourceFd2172;
		public virtual global::android.content.res.AssetFileDescriptor openRawResourceFd(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._openRawResourceFd2172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._openRawResourceFd2172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newTheme2173;
		public virtual global::android.content.res.Resources.Theme newTheme() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._newTheme2173));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._newTheme2173));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainAttributes2174;
		public virtual global::android.content.res.TypedArray obtainAttributes(android.util.AttributeSet arg0, int[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._obtainAttributes2174, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._obtainAttributes2174, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateConfiguration2175;
		public virtual void updateConfiguration(android.content.res.Configuration arg0, android.util.DisplayMetrics arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._updateConfiguration2175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._updateConfiguration2175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayMetrics2176;
		public virtual global::android.util.DisplayMetrics getDisplayMetrics() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.DisplayMetrics>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getDisplayMetrics2176));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.DisplayMetrics>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDisplayMetrics2176));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConfiguration2177;
		public virtual global::android.content.res.Configuration getConfiguration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Configuration>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getConfiguration2177));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Configuration>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getConfiguration2177));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResourceName2178;
		public virtual global::java.lang.String getResourceName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getResourceName2178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourceName2178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResourcePackageName2179;
		public virtual global::java.lang.String getResourcePackageName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getResourcePackageName2179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourcePackageName2179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResourceTypeName2180;
		public virtual global::java.lang.String getResourceTypeName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getResourceTypeName2180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourceTypeName2180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResourceEntryName2181;
		public virtual global::java.lang.String getResourceEntryName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getResourceEntryName2181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourceEntryName2181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parseBundleExtras2182;
		public virtual void parseBundleExtras(android.content.res.XmlResourceParser arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._parseBundleExtras2182, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._parseBundleExtras2182, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parseBundleExtra2183;
		public virtual void parseBundleExtra(java.lang.String arg0, android.util.AttributeSet arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._parseBundleExtra2183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._parseBundleExtra2183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flushLayoutCache2184;
		public virtual void flushLayoutCache() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._flushLayoutCache2184);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._flushLayoutCache2184);
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishPreloading2185;
		public virtual void finishPreloading() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._finishPreloading2185);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._finishPreloading2185);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Resources2186;
		public Resources(android.content.res.AssetManager arg0, android.util.DisplayMetrics arg1, android.content.res.Configuration arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.res.Resources.staticClass, global::android.content.res.Resources._Resources2186, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.res.Resources.staticClass = @__class;
			global::android.content.res.Resources._getBoolean2141 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getBoolean", "(I)Z");
			global::android.content.res.Resources._getValue2142 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getValue", "(ILandroid/util/TypedValue;Z)V");
			global::android.content.res.Resources._getValue2143 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V");
			global::android.content.res.Resources._getInteger2144 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getInteger", "(I)I");
			global::android.content.res.Resources._getString2145 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.content.res.Resources._getString2146 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.content.res.Resources._getIdentifier2147 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			global::android.content.res.Resources._getAssets2148 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			global::android.content.res.Resources._getText2149 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.content.res.Resources._getText2150 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.content.res.Resources._getSystem2151 = @__env.GetStaticMethodID(global::android.content.res.Resources.staticClass, "getSystem", "()Landroid/content/res/Resources;");
			global::android.content.res.Resources._getQuantityText2152 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getQuantityText", "(II)Ljava/lang/CharSequence;");
			global::android.content.res.Resources._getQuantityString2153 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.content.res.Resources._getQuantityString2154 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getQuantityString", "(II)Ljava/lang/String;");
			global::android.content.res.Resources._getTextArray2155 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			global::android.content.res.Resources._getStringArray2156 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getStringArray", "(I)[Ljava/lang/String;");
			global::android.content.res.Resources._getIntArray2157 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getIntArray", "(I)[I");
			global::android.content.res.Resources._obtainTypedArray2158 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "obtainTypedArray", "(I)Landroid/content/res/TypedArray;");
			global::android.content.res.Resources._getDimension2159 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDimension", "(I)F");
			global::android.content.res.Resources._getDimensionPixelOffset2160 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDimensionPixelOffset", "(I)I");
			global::android.content.res.Resources._getDimensionPixelSize2161 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDimensionPixelSize", "(I)I");
			global::android.content.res.Resources._getFraction2162 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getFraction", "(III)F");
			global::android.content.res.Resources._getDrawable2163 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.content.res.Resources._getMovie2164 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getMovie", "(I)Landroid/graphics/Movie;");
			global::android.content.res.Resources._getColor2165 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getColor", "(I)I");
			global::android.content.res.Resources._getColorStateList2166 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.Resources._getLayout2167 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getLayout", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.content.res.Resources._getAnimation2168 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getAnimation", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.content.res.Resources._getXml2169 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getXml", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.content.res.Resources._openRawResource2170 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "openRawResource", "(ILandroid/util/TypedValue;)Ljava/io/InputStream;");
			global::android.content.res.Resources._openRawResource2171 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "openRawResource", "(I)Ljava/io/InputStream;");
			global::android.content.res.Resources._openRawResourceFd2172 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.res.Resources._newTheme2173 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "newTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.content.res.Resources._obtainAttributes2174 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;");
			global::android.content.res.Resources._updateConfiguration2175 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V");
			global::android.content.res.Resources._getDisplayMetrics2176 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDisplayMetrics", "()Landroid/util/DisplayMetrics;");
			global::android.content.res.Resources._getConfiguration2177 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getConfiguration", "()Landroid/content/res/Configuration;");
			global::android.content.res.Resources._getResourceName2178 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourceName", "(I)Ljava/lang/String;");
			global::android.content.res.Resources._getResourcePackageName2179 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourcePackageName", "(I)Ljava/lang/String;");
			global::android.content.res.Resources._getResourceTypeName2180 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourceTypeName", "(I)Ljava/lang/String;");
			global::android.content.res.Resources._getResourceEntryName2181 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourceEntryName", "(I)Ljava/lang/String;");
			global::android.content.res.Resources._parseBundleExtras2182 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "parseBundleExtras", "(Landroid/content/res/XmlResourceParser;Landroid/os/Bundle;)V");
			global::android.content.res.Resources._parseBundleExtra2183 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "parseBundleExtra", "(Ljava/lang/String;Landroid/util/AttributeSet;Landroid/os/Bundle;)V");
			global::android.content.res.Resources._flushLayoutCache2184 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "flushLayoutCache", "()V");
			global::android.content.res.Resources._finishPreloading2185 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "finishPreloading", "()V");
			global::android.content.res.Resources._Resources2186 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "<init>", "(Landroid/content/res/AssetManager;Landroid/util/DisplayMetrics;Landroid/content/res/Configuration;)V");
		}
	}
}
