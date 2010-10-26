namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UrlQuerySanitizer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UrlQuerySanitizer()
		{
			InitJNI();
		}
		protected UrlQuerySanitizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class IllegalCharacterValueSanitizer : java.lang.Object, ValueSanitizer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static IllegalCharacterValueSanitizer()
			{
				InitJNI();
			}
			protected IllegalCharacterValueSanitizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _sanitize7861;
			public virtual global::java.lang.String sanitize(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize7861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize7861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _IllegalCharacterValueSanitizer7862;
			public IllegalCharacterValueSanitizer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._IllegalCharacterValueSanitizer7862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer$IllegalCharacterValueSanitizer"));
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize7861 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._IllegalCharacterValueSanitizer7862 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "<init>", "(I)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ParameterValuePair : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ParameterValuePair()
			{
				InitJNI();
			}
			protected ParameterValuePair(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ParameterValuePair7885;
			public ParameterValuePair(android.net.UrlQuerySanitizer arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, global::android.net.UrlQuerySanitizer.ParameterValuePair._ParameterValuePair7885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _mParameter7886;
			public global::java.lang.String mParameter
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _mParameter7886)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mValue7887;
			public global::java.lang.String mValue
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _mValue7887)) as java.lang.String;
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer$ParameterValuePair"));
				global::android.net.UrlQuerySanitizer.ParameterValuePair._ParameterValuePair7885 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "<init>", "(Landroid/net/UrlQuerySanitizer;Ljava/lang/String;Ljava/lang/String;)V");
				global::android.net.UrlQuerySanitizer.ParameterValuePair._mParameter7886 = @__env.GetFieldIDNoThrow(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "mParameter", "Ljava/lang/String;");
				global::android.net.UrlQuerySanitizer.ParameterValuePair._mValue7887 = @__env.GetFieldIDNoThrow(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "mValue", "Ljava/lang/String;");
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
			static ValueSanitizer_()
			{
				InitJNI();
			}
			internal ValueSanitizer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _sanitize7888;
			 global::java.lang.String android.net.UrlQuerySanitizer.ValueSanitizer.sanitize(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.ValueSanitizer_._sanitize7888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass, global::android.net.UrlQuerySanitizer.ValueSanitizer_._sanitize7888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer$ValueSanitizer"));
				global::android.net.UrlQuerySanitizer.ValueSanitizer_._sanitize7888 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;");
			}
		}

		public delegate java.lang.String ValueSanitizerDelegate(java.lang.String arg0);

		internal partial class ValueSanitizerDelegateWrapper : java.lang.Object, ValueSanitizer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ValueSanitizerDelegateWrapper()
			{
				InitJNI();
			}
			protected ValueSanitizerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ValueSanitizerDelegateWrapper7889;
			public ValueSanitizerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper.staticClass, global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper._ValueSanitizerDelegateWrapper7889);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer_ValueSanitizerDelegateWrapper"));
				global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper._ValueSanitizerDelegateWrapper7889 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _clear7890;
		protected virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._clear7890);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._clear7890);
		}
		internal static global::MonoJavaBridge.MethodId _getValue7891;
		public virtual global::java.lang.String getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getValue7891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getValue7891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _unescape7892;
		public virtual global::java.lang.String unescape(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._unescape7892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._unescape7892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isHexDigit7893;
		protected virtual bool isHexDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._isHexDigit7893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._isHexDigit7893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUnregisteredParameterValueSanitizer7894;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getUnregisteredParameterValueSanitizer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer7894)) as android.net.UrlQuerySanitizer.ValueSanitizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer7894)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _setUnregisteredParameterValueSanitizer7895;
		public virtual void setUnregisteredParameterValueSanitizer(android.net.UrlQuerySanitizer.ValueSanitizer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer7895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer7895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAllIllegal7896;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllIllegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllIllegal7896)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AllButNulLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAllButNulLegal().sanitize);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllButNulLegal7897;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButNulLegal7897)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AllButWhitespaceLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAllButWhitespaceLegal().sanitize);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllButWhitespaceLegal7898;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButWhitespaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButWhitespaceLegal7898)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate UrlLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getUrlLegal().sanitize);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrlLegal7899;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getUrlLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUrlLegal7899)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate UrlAndSpaceLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getUrlAndSpaceLegal().sanitize);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrlAndSpaceLegal7900;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getUrlAndSpaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUrlAndSpaceLegal7900)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AmpLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAmpLegal().sanitize);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAmpLegal7901;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAmpLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAmpLegal7901)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AmpAndSpaceLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAmpAndSpaceLegal().sanitize);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAmpAndSpaceLegal7902;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAmpAndSpaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAmpAndSpaceLegal7902)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate SpaceLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getSpaceLegal().sanitize);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpaceLegal7903;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getSpaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getSpaceLegal7903)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate AllButNulAndAngleBracketsLegal
		{
			get
			{
				return new global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate(getAllButNulAndAngleBracketsLegal().sanitize);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllButNulAndAngleBracketsLegal7904;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulAndAngleBracketsLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButNulAndAngleBracketsLegal7904)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _parseUrl7905;
		public virtual void parseUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._parseUrl7905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseUrl7905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseQuery7906;
		public virtual void parseQuery(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._parseQuery7906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseQuery7906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Set ParameterSet
		{
			get
			{
				return getParameterSet();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterSet7907;
		public virtual global::java.util.Set getParameterSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getParameterSet7907)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getParameterSet7907)) as java.util.Set;
		}
		public new global::java.util.List ParameterList
		{
			get
			{
				return getParameterList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterList7908;
		public virtual global::java.util.List getParameterList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getParameterList7908)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getParameterList7908)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _hasParameter7909;
		public virtual bool hasParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._hasParameter7909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._hasParameter7909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerParameter7910;
		public virtual void registerParameter(java.lang.String arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._registerParameter7910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._registerParameter7910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void registerParameter(java.lang.String arg0, global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate arg1)
		{
			registerParameter(arg0, (global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _registerParameters7911;
		public virtual void registerParameters(java.lang.String[] arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._registerParameters7911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._registerParameters7911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void registerParameters(java.lang.String[] arg0, global::android.net.UrlQuerySanitizer.ValueSanitizerDelegate arg1)
		{
			registerParameters(arg0, (global::android.net.UrlQuerySanitizer.ValueSanitizerDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setAllowUnregisteredParamaters7912;
		public virtual void setAllowUnregisteredParamaters(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters7912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters7912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAllowUnregisteredParamaters7913;
		public virtual bool getAllowUnregisteredParamaters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters7913);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters7913);
		}
		internal static global::MonoJavaBridge.MethodId _setPreferFirstRepeatedParameter7914;
		public virtual void setPreferFirstRepeatedParameter(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter7914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter7914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPreferFirstRepeatedParameter7915;
		public virtual bool getPreferFirstRepeatedParameter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter7915);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter7915);
		}
		internal static global::MonoJavaBridge.MethodId _parseEntry7916;
		protected virtual void parseEntry(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._parseEntry7916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseEntry7916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSanitizedEntry7917;
		protected virtual void addSanitizedEntry(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._addSanitizedEntry7917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._addSanitizedEntry7917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getValueSanitizer7918;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getValueSanitizer(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getValueSanitizer7918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getValueSanitizer7918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _getEffectiveValueSanitizer7919;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getEffectiveValueSanitizer(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer7919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer7919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _decodeHexDigit7920;
		protected virtual int decodeHexDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._decodeHexDigit7920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._decodeHexDigit7920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _UrlQuerySanitizer7921;
		public UrlQuerySanitizer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._UrlQuerySanitizer7921);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UrlQuerySanitizer7922;
		public UrlQuerySanitizer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._UrlQuerySanitizer7922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.UrlQuerySanitizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer"));
			global::android.net.UrlQuerySanitizer._clear7890 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "clear", "()V");
			global::android.net.UrlQuerySanitizer._getValue7891 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.UrlQuerySanitizer._unescape7892 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "unescape", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.UrlQuerySanitizer._isHexDigit7893 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "isHexDigit", "(C)Z");
			global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer7894 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUnregisteredParameterValueSanitizer", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer7895 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "setUnregisteredParameterValueSanitizer", "(Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V");
			global::android.net.UrlQuerySanitizer._getAllIllegal7896 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllIllegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAllButNulLegal7897 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAllButWhitespaceLegal7898 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButWhitespaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getUrlLegal7899 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUrlLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getUrlAndSpaceLegal7900 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUrlAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAmpLegal7901 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAmpLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAmpAndSpaceLegal7902 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAmpAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getSpaceLegal7903 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAllButNulAndAngleBracketsLegal7904 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulAndAngleBracketsLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._parseUrl7905 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "parseUrl", "(Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._parseQuery7906 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "parseQuery", "(Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._getParameterSet7907 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getParameterSet", "()Ljava/util/Set;");
			global::android.net.UrlQuerySanitizer._getParameterList7908 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getParameterList", "()Ljava/util/List;");
			global::android.net.UrlQuerySanitizer._hasParameter7909 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "hasParameter", "(Ljava/lang/String;)Z");
			global::android.net.UrlQuerySanitizer._registerParameter7910 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "registerParameter", "(Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V");
			global::android.net.UrlQuerySanitizer._registerParameters7911 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "registerParameters", "([Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V");
			global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters7912 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "setAllowUnregisteredParamaters", "(Z)V");
			global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters7913 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllowUnregisteredParamaters", "()Z");
			global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter7914 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "setPreferFirstRepeatedParameter", "(Z)V");
			global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter7915 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getPreferFirstRepeatedParameter", "()Z");
			global::android.net.UrlQuerySanitizer._parseEntry7916 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "parseEntry", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._addSanitizedEntry7917 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "addSanitizedEntry", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._getValueSanitizer7918 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer7919 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getEffectiveValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._decodeHexDigit7920 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "decodeHexDigit", "(C)I");
			global::android.net.UrlQuerySanitizer._UrlQuerySanitizer7921 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "()V");
			global::android.net.UrlQuerySanitizer._UrlQuerySanitizer7922 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
