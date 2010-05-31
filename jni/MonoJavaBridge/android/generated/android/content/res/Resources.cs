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
			internal static global::net.sf.jni4net.jni.MethodId _NotFoundException1951;
			public NotFoundException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.res.Resources.NotFoundException.staticClass, global::android.content.res.Resources.NotFoundException._NotFoundException1951, this);
			}
			internal static global::net.sf.jni4net.jni.MethodId _NotFoundException1952;
			public NotFoundException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.res.Resources.NotFoundException.staticClass, global::android.content.res.Resources.NotFoundException._NotFoundException1952, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.res.Resources.NotFoundException.staticClass = @__class;
				global::android.content.res.Resources.NotFoundException._NotFoundException1951 = @__env.GetMethodID(global::android.content.res.Resources.NotFoundException.staticClass, "<init>", "()V");
				global::android.content.res.Resources.NotFoundException._NotFoundException1952 = @__env.GetMethodID(global::android.content.res.Resources.NotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _dump1953;
			public void dump(int arg0, java.lang.String arg1, java.lang.String arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.Resources.Theme._dump1953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._dump1953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1954;
			public global::android.content.res.TypedArray obtainStyledAttributes(int[] arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources.Theme._obtainStyledAttributes1954, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._obtainStyledAttributes1954, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1955;
			public global::android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources.Theme._obtainStyledAttributes1955, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._obtainStyledAttributes1955, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1956;
			public global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources.Theme._obtainStyledAttributes1956, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._obtainStyledAttributes1956, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _applyStyle1957;
			public void applyStyle(int arg0, bool arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.Resources.Theme._applyStyle1957, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._applyStyle1957, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setTo1958;
			public void setTo(android.content.res.Resources.Theme arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.Resources.Theme._setTo1958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._setTo1958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _resolveAttribute1959;
			public bool resolveAttribute(int arg0, android.util.TypedValue arg1, bool arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.content.res.Resources.Theme._resolveAttribute1959, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._resolveAttribute1959, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.res.Resources.Theme.staticClass = @__class;
				global::android.content.res.Resources.Theme._dump1953 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "dump", "(ILjava/lang/String;Ljava/lang/String;)V");
				global::android.content.res.Resources.Theme._obtainStyledAttributes1954 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;");
				global::android.content.res.Resources.Theme._obtainStyledAttributes1955 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;");
				global::android.content.res.Resources.Theme._obtainStyledAttributes1956 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;");
				global::android.content.res.Resources.Theme._applyStyle1957 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "applyStyle", "(IZ)V");
				global::android.content.res.Resources.Theme._setTo1958 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "setTo", "(Landroid/content/res/Resources$Theme;)V");
				global::android.content.res.Resources.Theme._resolveAttribute1959 = @__env.GetMethodID(global::android.content.res.Resources.Theme.staticClass, "resolveAttribute", "(ILandroid/util/TypedValue;Z)Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean1960;
		public virtual bool getBoolean(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.Resources._getBoolean1960, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getBoolean1960, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue1961;
		public virtual void getValue(int arg0, android.util.TypedValue arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._getValue1961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getValue1961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue1962;
		public virtual void getValue(java.lang.String arg0, android.util.TypedValue arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._getValue1962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getValue1962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInteger1963;
		public virtual int getInteger(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Resources._getInteger1963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getInteger1963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString1964;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getString1964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getString1964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString1965;
		public virtual global::java.lang.String getString(int arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getString1965, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getString1965, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIdentifier1966;
		public virtual int getIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Resources._getIdentifier1966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getIdentifier1966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAssets1967;
		public virtual global::android.content.res.AssetManager getAssets() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getAssets1967));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getAssets1967));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText1968;
		public virtual global::java.lang.CharSequence getText(int arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getText1968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getText1968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		public java.lang.CharSequence getText(int arg0, string arg1)
		{
			return getText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText1969;
		public virtual global::java.lang.CharSequence getText(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getText1969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getText1969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSystem1970;
		public static global::android.content.res.Resources getSystem() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallStaticObjectMethodPtr(android.content.res.Resources.staticClass, global::android.content.res.Resources._getSystem1970));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getQuantityText1971;
		public virtual global::java.lang.CharSequence getQuantityText(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getQuantityText1971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getQuantityText1971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getQuantityString1972;
		public virtual global::java.lang.String getQuantityString(int arg0, int arg1, java.lang.Object[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getQuantityString1972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getQuantityString1972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getQuantityString1973;
		public virtual global::java.lang.String getQuantityString(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getQuantityString1973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getQuantityString1973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextArray1974;
		public virtual global::java.lang.CharSequence[] getTextArray(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getTextArray1974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getTextArray1974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStringArray1975;
		public virtual global::java.lang.String[] getStringArray(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getStringArray1975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getStringArray1975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntArray1976;
		public virtual int[] getIntArray(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getIntArray1976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getIntArray1976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainTypedArray1977;
		public virtual global::android.content.res.TypedArray obtainTypedArray(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._obtainTypedArray1977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._obtainTypedArray1977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDimension1978;
		public virtual float getDimension(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.content.res.Resources._getDimension1978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDimension1978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelOffset1979;
		public virtual int getDimensionPixelOffset(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Resources._getDimensionPixelOffset1979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDimensionPixelOffset1979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDimensionPixelSize1980;
		public virtual int getDimensionPixelSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Resources._getDimensionPixelSize1980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDimensionPixelSize1980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFraction1981;
		public virtual float getFraction(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.content.res.Resources._getFraction1981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getFraction1981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable1982;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getDrawable1982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDrawable1982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMovie1983;
		public virtual global::android.graphics.Movie getMovie(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getMovie1983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getMovie1983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColor1984;
		public virtual int getColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Resources._getColor1984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getColor1984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColorStateList1985;
		public virtual global::android.content.res.ColorStateList getColorStateList(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getColorStateList1985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getColorStateList1985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayout1986;
		public virtual global::android.content.res.XmlResourceParser getLayout(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getLayout1986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getLayout1986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnimation1987;
		public virtual global::android.content.res.XmlResourceParser getAnimation(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getAnimation1987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getAnimation1987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getXml1988;
		public virtual global::android.content.res.XmlResourceParser getXml(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getXml1988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getXml1988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openRawResource1989;
		public virtual global::java.io.InputStream openRawResource(int arg0, android.util.TypedValue arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._openRawResource1989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._openRawResource1989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openRawResource1990;
		public virtual global::java.io.InputStream openRawResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._openRawResource1990, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._openRawResource1990, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openRawResourceFd1991;
		public virtual global::android.content.res.AssetFileDescriptor openRawResourceFd(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._openRawResourceFd1991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._openRawResourceFd1991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newTheme1992;
		public virtual global::android.content.res.Resources.Theme newTheme() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._newTheme1992));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._newTheme1992));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainAttributes1993;
		public virtual global::android.content.res.TypedArray obtainAttributes(android.util.AttributeSet arg0, int[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._obtainAttributes1993, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._obtainAttributes1993, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateConfiguration1994;
		public virtual void updateConfiguration(android.content.res.Configuration arg0, android.util.DisplayMetrics arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._updateConfiguration1994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._updateConfiguration1994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayMetrics1995;
		public virtual global::android.util.DisplayMetrics getDisplayMetrics() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.DisplayMetrics>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getDisplayMetrics1995));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.DisplayMetrics>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDisplayMetrics1995));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConfiguration1996;
		public virtual global::android.content.res.Configuration getConfiguration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Configuration>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getConfiguration1996));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Configuration>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getConfiguration1996));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResourceName1997;
		public virtual global::java.lang.String getResourceName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getResourceName1997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourceName1997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResourcePackageName1998;
		public virtual global::java.lang.String getResourcePackageName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getResourcePackageName1998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourcePackageName1998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResourceTypeName1999;
		public virtual global::java.lang.String getResourceTypeName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getResourceTypeName1999, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourceTypeName1999, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResourceEntryName2000;
		public virtual global::java.lang.String getResourceEntryName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Resources._getResourceEntryName2000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourceEntryName2000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parseBundleExtras2001;
		public virtual void parseBundleExtras(android.content.res.XmlResourceParser arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._parseBundleExtras2001, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._parseBundleExtras2001, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parseBundleExtra2002;
		public virtual void parseBundleExtra(java.lang.String arg0, android.util.AttributeSet arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._parseBundleExtra2002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._parseBundleExtra2002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flushLayoutCache2003;
		public virtual void flushLayoutCache() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._flushLayoutCache2003);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._flushLayoutCache2003);
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishPreloading2004;
		public virtual void finishPreloading() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Resources._finishPreloading2004);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._finishPreloading2004);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Resources2005;
		public Resources(android.content.res.AssetManager arg0, android.util.DisplayMetrics arg1, android.content.res.Configuration arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.res.Resources.staticClass, global::android.content.res.Resources._Resources2005, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.res.Resources.staticClass = @__class;
			global::android.content.res.Resources._getBoolean1960 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getBoolean", "(I)Z");
			global::android.content.res.Resources._getValue1961 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getValue", "(ILandroid/util/TypedValue;Z)V");
			global::android.content.res.Resources._getValue1962 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V");
			global::android.content.res.Resources._getInteger1963 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getInteger", "(I)I");
			global::android.content.res.Resources._getString1964 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.content.res.Resources._getString1965 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.content.res.Resources._getIdentifier1966 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			global::android.content.res.Resources._getAssets1967 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			global::android.content.res.Resources._getText1968 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
			global::android.content.res.Resources._getText1969 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.content.res.Resources._getSystem1970 = @__env.GetStaticMethodID(global::android.content.res.Resources.staticClass, "getSystem", "()Landroid/content/res/Resources;");
			global::android.content.res.Resources._getQuantityText1971 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getQuantityText", "(II)Ljava/lang/CharSequence;");
			global::android.content.res.Resources._getQuantityString1972 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.content.res.Resources._getQuantityString1973 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getQuantityString", "(II)Ljava/lang/String;");
			global::android.content.res.Resources._getTextArray1974 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			global::android.content.res.Resources._getStringArray1975 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getStringArray", "(I)[Ljava/lang/String;");
			global::android.content.res.Resources._getIntArray1976 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getIntArray", "(I)[I");
			global::android.content.res.Resources._obtainTypedArray1977 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "obtainTypedArray", "(I)Landroid/content/res/TypedArray;");
			global::android.content.res.Resources._getDimension1978 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDimension", "(I)F");
			global::android.content.res.Resources._getDimensionPixelOffset1979 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDimensionPixelOffset", "(I)I");
			global::android.content.res.Resources._getDimensionPixelSize1980 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDimensionPixelSize", "(I)I");
			global::android.content.res.Resources._getFraction1981 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getFraction", "(III)F");
			global::android.content.res.Resources._getDrawable1982 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.content.res.Resources._getMovie1983 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getMovie", "(I)Landroid/graphics/Movie;");
			global::android.content.res.Resources._getColor1984 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getColor", "(I)I");
			global::android.content.res.Resources._getColorStateList1985 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.Resources._getLayout1986 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getLayout", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.content.res.Resources._getAnimation1987 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getAnimation", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.content.res.Resources._getXml1988 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getXml", "(I)Landroid/content/res/XmlResourceParser;");
			global::android.content.res.Resources._openRawResource1989 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "openRawResource", "(ILandroid/util/TypedValue;)Ljava/io/InputStream;");
			global::android.content.res.Resources._openRawResource1990 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "openRawResource", "(I)Ljava/io/InputStream;");
			global::android.content.res.Resources._openRawResourceFd1991 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.res.Resources._newTheme1992 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "newTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.content.res.Resources._obtainAttributes1993 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;");
			global::android.content.res.Resources._updateConfiguration1994 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V");
			global::android.content.res.Resources._getDisplayMetrics1995 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getDisplayMetrics", "()Landroid/util/DisplayMetrics;");
			global::android.content.res.Resources._getConfiguration1996 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getConfiguration", "()Landroid/content/res/Configuration;");
			global::android.content.res.Resources._getResourceName1997 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourceName", "(I)Ljava/lang/String;");
			global::android.content.res.Resources._getResourcePackageName1998 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourcePackageName", "(I)Ljava/lang/String;");
			global::android.content.res.Resources._getResourceTypeName1999 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourceTypeName", "(I)Ljava/lang/String;");
			global::android.content.res.Resources._getResourceEntryName2000 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "getResourceEntryName", "(I)Ljava/lang/String;");
			global::android.content.res.Resources._parseBundleExtras2001 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "parseBundleExtras", "(Landroid/content/res/XmlResourceParser;Landroid/os/Bundle;)V");
			global::android.content.res.Resources._parseBundleExtra2002 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "parseBundleExtra", "(Ljava/lang/String;Landroid/util/AttributeSet;Landroid/os/Bundle;)V");
			global::android.content.res.Resources._flushLayoutCache2003 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "flushLayoutCache", "()V");
			global::android.content.res.Resources._finishPreloading2004 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "finishPreloading", "()V");
			global::android.content.res.Resources._Resources2005 = @__env.GetMethodID(global::android.content.res.Resources.staticClass, "<init>", "(Landroid/content/res/AssetManager;Landroid/util/DisplayMetrics;Landroid/content/res/Configuration;)V");
		}
	}
}
