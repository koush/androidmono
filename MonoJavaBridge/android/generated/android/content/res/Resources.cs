namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Resources : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Resources(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class NotFoundException : java.lang.RuntimeException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected NotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _NotFoundException4201;
			public NotFoundException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.NotFoundException._NotFoundException4201.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.NotFoundException._NotFoundException4201 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.NotFoundException.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Resources.NotFoundException.staticClass, global::android.content.res.Resources.NotFoundException._NotFoundException4201);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _NotFoundException4202;
			public NotFoundException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.NotFoundException._NotFoundException4202.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.NotFoundException._NotFoundException4202 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.NotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Resources.NotFoundException.staticClass, global::android.content.res.Resources.NotFoundException._NotFoundException4202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static NotFoundException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.Resources.NotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/Resources$NotFoundException"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Theme : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Theme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _dump4203;
			public void dump(int arg0, java.lang.String arg1, java.lang.String arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.Theme._dump4203.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.Theme._dump4203 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.Theme.staticClass, "dump", "(ILjava/lang/String;Ljava/lang/String;)V");
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._dump4203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes4204;
			public global::android.content.res.TypedArray obtainStyledAttributes(int[] arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.Theme._obtainStyledAttributes4204.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.Theme._obtainStyledAttributes4204 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._obtainStyledAttributes4204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.TypedArray;
			}
			internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes4205;
			public global::android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.Theme._obtainStyledAttributes4205.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.Theme._obtainStyledAttributes4205 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._obtainStyledAttributes4205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.TypedArray;
			}
			internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes4206;
			public global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.Theme._obtainStyledAttributes4206.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.Theme._obtainStyledAttributes4206 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._obtainStyledAttributes4206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.res.TypedArray;
			}
			public new global::android.content.res.Resources.Theme To
			{
				set
				{
					setTo(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setTo4207;
			public void setTo(android.content.res.Resources.Theme arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.Theme._setTo4207.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.Theme._setTo4207 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.Theme.staticClass, "setTo", "(Landroid/content/res/Resources$Theme;)V");
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._setTo4207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _applyStyle4208;
			public void applyStyle(int arg0, bool arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.Theme._applyStyle4208.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.Theme._applyStyle4208 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.Theme.staticClass, "applyStyle", "(IZ)V");
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._applyStyle4208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _resolveAttribute4209;
			public bool resolveAttribute(int arg0, android.util.TypedValue arg1, bool arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.Theme._resolveAttribute4209.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.Theme._resolveAttribute4209 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.Theme.staticClass, "resolveAttribute", "(ILandroid/util/TypedValue;Z)Z");
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.Resources.Theme.staticClass, global::android.content.res.Resources.Theme._resolveAttribute4209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static Theme()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.Resources.Theme.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/Resources$Theme"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean4210;
		public virtual bool getBoolean(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getBoolean4210.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getBoolean4210 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getBoolean", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getBoolean4210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getValue4211;
		public virtual void getValue(int arg0, android.util.TypedValue arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getValue4211.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getValue4211 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getValue", "(ILandroid/util/TypedValue;Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getValue4211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getValue4212;
		public virtual void getValue(java.lang.String arg0, android.util.TypedValue arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getValue4212.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getValue4212 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getValue4212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getInteger4213;
		public virtual int getInteger(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getInteger4213.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getInteger4213 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getInteger", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getInteger4213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString4214;
		public virtual global::java.lang.String getString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getString4214.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getString4214 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getString4214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString4215;
		public virtual global::java.lang.String getString(int arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getString4215.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getString4215 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getString4215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIdentifier4216;
		public virtual int getIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getIdentifier4216.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getIdentifier4216 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getIdentifier4216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.content.res.AssetManager Assets
		{
			get
			{
				return getAssets();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAssets4217;
		public virtual global::android.content.res.AssetManager getAssets()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getAssets4217.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getAssets4217 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.AssetManager>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getAssets4217) as android.content.res.AssetManager;
		}
		internal static global::MonoJavaBridge.MethodId _getText4218;
		public virtual global::java.lang.CharSequence getText(int arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getText4218.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getText4218 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getText4218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		public java.lang.CharSequence getText(int arg0, string arg1)
		{
			return getText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getText4219;
		public virtual global::java.lang.CharSequence getText(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getText4219.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getText4219 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getText4219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		public static global::android.content.res.Resources System
		{
			get
			{
				return getSystem();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystem4220;
		public static global::android.content.res.Resources getSystem()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getSystem4220.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getSystem4220 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getSystem", "()Landroid/content/res/Resources;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.res.Resources.staticClass, global::android.content.res.Resources._getSystem4220)) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityText4221;
		public virtual global::java.lang.CharSequence getQuantityText(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getQuantityText4221.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getQuantityText4221 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getQuantityText", "(II)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getQuantityText4221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityString4222;
		public virtual global::java.lang.String getQuantityString(int arg0, int arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getQuantityString4222.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getQuantityString4222 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getQuantityString4222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQuantityString4223;
		public virtual global::java.lang.String getQuantityString(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getQuantityString4223.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getQuantityString4223 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getQuantityString", "(II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getQuantityString4223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTextArray4224;
		public virtual global::java.lang.CharSequence[] getTextArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getTextArray4224.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getTextArray4224 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.CharSequence>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getTextArray4224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _getStringArray4225;
		public virtual global::java.lang.String[] getStringArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getStringArray4225.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getStringArray4225 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getStringArray", "(I)[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getStringArray4225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getIntArray4226;
		public virtual int[] getIntArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getIntArray4226.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getIntArray4226 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getIntArray", "(I)[I");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getIntArray4226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _obtainTypedArray4227;
		public virtual global::android.content.res.TypedArray obtainTypedArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._obtainTypedArray4227.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._obtainTypedArray4227 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "obtainTypedArray", "(I)Landroid/content/res/TypedArray;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._obtainTypedArray4227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _getDimension4228;
		public virtual float getDimension(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getDimension4228.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getDimension4228 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getDimension", "(I)F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDimension4228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelOffset4229;
		public virtual int getDimensionPixelOffset(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getDimensionPixelOffset4229.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getDimensionPixelOffset4229 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getDimensionPixelOffset", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDimensionPixelOffset4229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelSize4230;
		public virtual int getDimensionPixelSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getDimensionPixelSize4230.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getDimensionPixelSize4230 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getDimensionPixelSize", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDimensionPixelSize4230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFraction4231;
		public virtual float getFraction(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getFraction4231.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getFraction4231 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getFraction", "(III)F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getFraction4231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable4232;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getDrawable4232.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getDrawable4232 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDrawable4232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getMovie4233;
		public virtual global::android.graphics.Movie getMovie(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getMovie4233.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getMovie4233 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getMovie", "(I)Landroid/graphics/Movie;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getMovie4233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Movie;
		}
		internal static global::MonoJavaBridge.MethodId _getColor4234;
		public virtual int getColor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getColor4234.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getColor4234 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getColor", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getColor4234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColorStateList4235;
		public virtual global::android.content.res.ColorStateList getColorStateList(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getColorStateList4235.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getColorStateList4235 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getColorStateList4235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getLayout4236;
		public virtual global::android.content.res.XmlResourceParser getLayout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getLayout4236.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getLayout4236 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getLayout", "(I)Landroid/content/res/XmlResourceParser;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getLayout4236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _getAnimation4237;
		public virtual global::android.content.res.XmlResourceParser getAnimation(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getAnimation4237.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getAnimation4237 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getAnimation", "(I)Landroid/content/res/XmlResourceParser;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getAnimation4237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _getXml4238;
		public virtual global::android.content.res.XmlResourceParser getXml(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getXml4238.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getXml4238 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getXml", "(I)Landroid/content/res/XmlResourceParser;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getXml4238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _openRawResource4239;
		public virtual global::java.io.InputStream openRawResource(int arg0, android.util.TypedValue arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._openRawResource4239.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._openRawResource4239 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "openRawResource", "(ILandroid/util/TypedValue;)Ljava/io/InputStream;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._openRawResource4239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openRawResource4240;
		public virtual global::java.io.InputStream openRawResource(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._openRawResource4240.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._openRawResource4240 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "openRawResource", "(I)Ljava/io/InputStream;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._openRawResource4240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openRawResourceFd4241;
		public virtual global::android.content.res.AssetFileDescriptor openRawResourceFd(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._openRawResourceFd4241.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._openRawResourceFd4241 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._openRawResourceFd4241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _newTheme4242;
		public virtual global::android.content.res.Resources.Theme newTheme()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._newTheme4242.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._newTheme4242 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "newTheme", "()Landroid/content/res/Resources$Theme;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.Resources.Theme>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._newTheme4242) as android.content.res.Resources.Theme;
		}
		internal static global::MonoJavaBridge.MethodId _obtainAttributes4243;
		public virtual global::android.content.res.TypedArray obtainAttributes(android.util.AttributeSet arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._obtainAttributes4243.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._obtainAttributes4243 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._obtainAttributes4243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _updateConfiguration4244;
		public virtual void updateConfiguration(android.content.res.Configuration arg0, android.util.DisplayMetrics arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._updateConfiguration4244.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._updateConfiguration4244 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._updateConfiguration4244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.util.DisplayMetrics DisplayMetrics
		{
			get
			{
				return getDisplayMetrics();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayMetrics4245;
		public virtual global::android.util.DisplayMetrics getDisplayMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getDisplayMetrics4245.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getDisplayMetrics4245 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getDisplayMetrics", "()Landroid/util/DisplayMetrics;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getDisplayMetrics4245) as android.util.DisplayMetrics;
		}
		public new global::android.content.res.Configuration Configuration
		{
			get
			{
				return getConfiguration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConfiguration4246;
		public virtual global::android.content.res.Configuration getConfiguration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getConfiguration4246.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getConfiguration4246 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getConfiguration", "()Landroid/content/res/Configuration;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.Configuration>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getConfiguration4246) as android.content.res.Configuration;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceName4247;
		public virtual global::java.lang.String getResourceName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getResourceName4247.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getResourceName4247 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getResourceName", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourceName4247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcePackageName4248;
		public virtual global::java.lang.String getResourcePackageName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getResourcePackageName4248.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getResourcePackageName4248 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getResourcePackageName", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourcePackageName4248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceTypeName4249;
		public virtual global::java.lang.String getResourceTypeName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getResourceTypeName4249.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getResourceTypeName4249 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getResourceTypeName", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourceTypeName4249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceEntryName4250;
		public virtual global::java.lang.String getResourceEntryName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._getResourceEntryName4250.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._getResourceEntryName4250 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getResourceEntryName", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._getResourceEntryName4250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parseBundleExtras4251;
		public virtual void parseBundleExtras(android.content.res.XmlResourceParser arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._parseBundleExtras4251.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._parseBundleExtras4251 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "parseBundleExtras", "(Landroid/content/res/XmlResourceParser;Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._parseBundleExtras4251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseBundleExtra4252;
		public virtual void parseBundleExtra(java.lang.String arg0, android.util.AttributeSet arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._parseBundleExtra4252.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._parseBundleExtra4252 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "parseBundleExtra", "(Ljava/lang/String;Landroid/util/AttributeSet;Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._parseBundleExtra4252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flushLayoutCache4253;
		public virtual void flushLayoutCache()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._flushLayoutCache4253.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._flushLayoutCache4253 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "flushLayoutCache", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._flushLayoutCache4253);
		}
		internal static global::MonoJavaBridge.MethodId _finishPreloading4254;
		public virtual void finishPreloading()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._finishPreloading4254.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._finishPreloading4254 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "finishPreloading", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, global::android.content.res.Resources._finishPreloading4254);
		}
		internal static global::MonoJavaBridge.MethodId _Resources4255;
		public Resources(android.content.res.AssetManager arg0, android.util.DisplayMetrics arg1, android.content.res.Configuration arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._Resources4255.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._Resources4255 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "<init>", "(Landroid/content/res/AssetManager;Landroid/util/DisplayMetrics;Landroid/content/res/Configuration;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Resources.staticClass, global::android.content.res.Resources._Resources4255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Resources()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.Resources.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/Resources"));
		}
		internal static void InitJNI()
		{
		}
	}
}
