namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UrlQuerySanitizer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UrlQuerySanitizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class IllegalCharacterValueSanitizer : java.lang.Object, ValueSanitizer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected IllegalCharacterValueSanitizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::java.lang.String sanitize(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public IllegalCharacterValueSanitizer(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._m1.native == global::System.IntPtr.Zero)
					global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._m1 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "<init>", "(I)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			public static int SPACE_OK
			{
				get
				{
					return 1;
				}
			}
			public static int OTHER_WHITESPACE_OK
			{
				get
				{
					return 2;
				}
			}
			public static int NON_7_BIT_ASCII_OK
			{
				get
				{
					return 4;
				}
			}
			public static int DQUOTE_OK
			{
				get
				{
					return 8;
				}
			}
			public static int SQUOTE_OK
			{
				get
				{
					return 16;
				}
			}
			public static int LT_OK
			{
				get
				{
					return 32;
				}
			}
			public static int GT_OK
			{
				get
				{
					return 64;
				}
			}
			public static int AMP_OK
			{
				get
				{
					return 128;
				}
			}
			public static int PCT_OK
			{
				get
				{
					return 256;
				}
			}
			public static int NUL_OK
			{
				get
				{
					return 512;
				}
			}
			public static int SCRIPT_URL_OK
			{
				get
				{
					return 1024;
				}
			}
			public static int ALL_OK
			{
				get
				{
					return 2047;
				}
			}
			public static int ALL_WHITESPACE_OK
			{
				get
				{
					return 3;
				}
			}
			public static int ALL_ILLEGAL
			{
				get
				{
					return 0;
				}
			}
			public static int ALL_BUT_NUL_LEGAL
			{
				get
				{
					return 1535;
				}
			}
			public static int ALL_BUT_WHITESPACE_LEGAL
			{
				get
				{
					return 1532;
				}
			}
			public static int URL_LEGAL
			{
				get
				{
					return 404;
				}
			}
			public static int URL_AND_SPACE_LEGAL
			{
				get
				{
					return 405;
				}
			}
			public static int AMP_LEGAL
			{
				get
				{
					return 128;
				}
			}
			public static int AMP_AND_SPACE_LEGAL
			{
				get
				{
					return 129;
				}
			}
			public static int SPACE_LEGAL
			{
				get
				{
					return 1;
				}
			}
			public static int ALL_BUT_NUL_AND_ANGLE_BRACKETS_LEGAL
			{
				get
				{
					return 1439;
				}
			}
			static IllegalCharacterValueSanitizer()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer$IllegalCharacterValueSanitizer"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ParameterValuePair : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ParameterValuePair(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ParameterValuePair(android.net.UrlQuerySanitizer arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.UrlQuerySanitizer.ParameterValuePair._m0.native == global::System.IntPtr.Zero)
					global::android.net.UrlQuerySanitizer.ParameterValuePair._m0 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "<init>", "(Landroid/net/UrlQuerySanitizer;Ljava/lang/String;Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, global::android.net.UrlQuerySanitizer.ParameterValuePair._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _mParameter3017;
			public global::java.lang.String mParameter
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _mParameter3017)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mValue3018;
			public global::java.lang.String mValue
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _mValue3018)) as java.lang.String;
				}
				set
				{
				}
			}
			static ParameterValuePair()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer$ParameterValuePair"));
				global::android.net.UrlQuerySanitizer.ParameterValuePair._mParameter3017 = @__env.GetFieldIDNoThrow(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "mParameter", "Ljava/lang/String;");
				global::android.net.UrlQuerySanitizer.ParameterValuePair._mValue3018 = @__env.GetFieldIDNoThrow(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "mValue", "Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.net.UrlQuerySanitizer.ValueSanitizer_))]
		public partial interface ValueSanitizer  : global::MonoJavaBridge.IJavaObject 
		{
			global::java.lang.String sanitize(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.net.UrlQuerySanitizer.ValueSanitizer))]
		internal sealed partial class ValueSanitizer_ : java.lang.Object, ValueSanitizer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ValueSanitizer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::java.lang.String android.net.UrlQuerySanitizer.ValueSanitizer.sanitize(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.net.UrlQuerySanitizer.ValueSanitizer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
			}
			static ValueSanitizer_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer$ValueSanitizer"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate java.lang.String ValueSanitizerDelegate(java.lang.String arg0);

		internal partial class ValueSanitizerDelegateWrapper : java.lang.Object, ValueSanitizer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ValueSanitizerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ValueSanitizerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper.staticClass, global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static ValueSanitizerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer_ValueSanitizerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class ValueSanitizerDelegateWrapper
		{
			private ValueSanitizerDelegate myDelegate;
			public java.lang.String sanitize(java.lang.String arg0)
			{
				return myDelegate(arg0);
			}
			public static implicit operator ValueSanitizerDelegateWrapper(ValueSanitizerDelegate d)
			{
				global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper ret = new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "clear", "()V", ref global::android.net.UrlQuerySanitizer._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.UrlQuerySanitizer.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.net.UrlQuerySanitizer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String unescape(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.UrlQuerySanitizer.staticClass, "unescape", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.net.UrlQuerySanitizer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual bool isHexDigit(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "isHexDigit", "(C)Z", ref global::android.net.UrlQuerySanitizer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate UnregisteredParameterValueSanitizer
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getUnregisteredParameterValueSanitizer().sanitize);
			}
			set
			{
				setUnregisteredParameterValueSanitizer(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getUnregisteredParameterValueSanitizer()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.net.UrlQuerySanitizer.ValueSanitizer>(this, global::android.net.UrlQuerySanitizer.staticClass, "getUnregisteredParameterValueSanitizer", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", ref global::android.net.UrlQuerySanitizer._m4) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setUnregisteredParameterValueSanitizer(android.net.UrlQuerySanitizer.ValueSanitizer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "setUnregisteredParameterValueSanitizer", "(Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V", ref global::android.net.UrlQuerySanitizer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setUnregisteredParameterValueSanitizer(global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate arg0)
		{
			setUnregisteredParameterValueSanitizer((global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper)arg0);
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AllIllegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAllIllegal().sanitize);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllIllegal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m6.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m6 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllIllegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m6)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AllButNulLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAllButNulLegal().sanitize);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulLegal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m7.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m7 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m7)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AllButWhitespaceLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAllButWhitespaceLegal().sanitize);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButWhitespaceLegal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m8.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m8 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButWhitespaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m8)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate UrlLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getUrlLegal().sanitize);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getUrlLegal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m9.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m9 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUrlLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m9)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate UrlAndSpaceLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getUrlAndSpaceLegal().sanitize);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getUrlAndSpaceLegal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m10.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m10 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUrlAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m10)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AmpLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAmpLegal().sanitize);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAmpLegal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m11.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m11 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAmpLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m11)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AmpAndSpaceLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAmpAndSpaceLegal().sanitize);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAmpAndSpaceLegal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m12.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m12 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAmpAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m12)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate SpaceLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getSpaceLegal().sanitize);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getSpaceLegal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m13.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m13 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m13)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AllButNulAndAngleBracketsLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAllButNulAndAngleBracketsLegal().sanitize);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulAndAngleBracketsLegal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m14.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m14 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulAndAngleBracketsLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m14)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void parseUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "parseUrl", "(Ljava/lang/String;)V", ref global::android.net.UrlQuerySanitizer._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void parseQuery(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "parseQuery", "(Ljava/lang/String;)V", ref global::android.net.UrlQuerySanitizer._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Set ParameterSet
		{
			get
			{
				return getParameterSet();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.util.Set getParameterSet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.net.UrlQuerySanitizer.staticClass, "getParameterSet", "()Ljava/util/Set;", ref global::android.net.UrlQuerySanitizer._m17) as java.util.Set;
		}
		public new global::java.util.List ParameterList
		{
			get
			{
				return getParameterList();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.util.List getParameterList()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.net.UrlQuerySanitizer.staticClass, "getParameterList", "()Ljava/util/List;", ref global::android.net.UrlQuerySanitizer._m18) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool hasParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "hasParameter", "(Ljava/lang/String;)Z", ref global::android.net.UrlQuerySanitizer._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void registerParameter(java.lang.String arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "registerParameter", "(Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V", ref global::android.net.UrlQuerySanitizer._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void registerParameter(java.lang.String arg0, global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate arg1)
		{
			registerParameter(arg0, (global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void registerParameters(java.lang.String[] arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "registerParameters", "([Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V", ref global::android.net.UrlQuerySanitizer._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void registerParameters(java.lang.String[] arg0, global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate arg1)
		{
			registerParameters(arg0, (global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setAllowUnregisteredParamaters(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "setAllowUnregisteredParamaters", "(Z)V", ref global::android.net.UrlQuerySanitizer._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool AllowUnregisteredParamaters
		{
			get
			{
				return getAllowUnregisteredParamaters();
			}
			set
			{
				setAllowUnregisteredParamaters(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool getAllowUnregisteredParamaters()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "getAllowUnregisteredParamaters", "()Z", ref global::android.net.UrlQuerySanitizer._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setPreferFirstRepeatedParameter(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "setPreferFirstRepeatedParameter", "(Z)V", ref global::android.net.UrlQuerySanitizer._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool PreferFirstRepeatedParameter
		{
			get
			{
				return getPreferFirstRepeatedParameter();
			}
			set
			{
				setPreferFirstRepeatedParameter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool getPreferFirstRepeatedParameter()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "getPreferFirstRepeatedParameter", "()Z", ref global::android.net.UrlQuerySanitizer._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected virtual void parseEntry(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "parseEntry", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.net.UrlQuerySanitizer._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected virtual void addSanitizedEntry(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "addSanitizedEntry", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.net.UrlQuerySanitizer._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getValueSanitizer(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.net.UrlQuerySanitizer.ValueSanitizer>(this, global::android.net.UrlQuerySanitizer.staticClass, "getValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;", ref global::android.net.UrlQuerySanitizer._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getEffectiveValueSanitizer(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.net.UrlQuerySanitizer.ValueSanitizer>(this, global::android.net.UrlQuerySanitizer.staticClass, "getEffectiveValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;", ref global::android.net.UrlQuerySanitizer._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		protected virtual int decodeHexDigit(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.UrlQuerySanitizer.staticClass, "decodeHexDigit", "(C)I", ref global::android.net.UrlQuerySanitizer._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public UrlQuerySanitizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m31.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m31 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m31);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public UrlQuerySanitizer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.UrlQuerySanitizer._m32.native == global::System.IntPtr.Zero)
				global::android.net.UrlQuerySanitizer._m32 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UrlQuerySanitizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.UrlQuerySanitizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
