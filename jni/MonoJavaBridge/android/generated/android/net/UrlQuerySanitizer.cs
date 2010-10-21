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
			internal static global::MonoJavaBridge.MethodId _sanitize7822;
			public virtual global::java.lang.String sanitize(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize7822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize7822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _IllegalCharacterValueSanitizer7823;
			public IllegalCharacterValueSanitizer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._IllegalCharacterValueSanitizer7823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize7822 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._IllegalCharacterValueSanitizer7823 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "<init>", "(I)V");
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
			internal static global::MonoJavaBridge.MethodId _ParameterValuePair7846;
			public ParameterValuePair(android.net.UrlQuerySanitizer arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, global::android.net.UrlQuerySanitizer.ParameterValuePair._ParameterValuePair7846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _mParameter7847;
			public global::java.lang.String mParameter
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _mParameter7847)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mValue7848;
			public global::java.lang.String mValue
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _mValue7848)) as java.lang.String;
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer$ParameterValuePair"));
				global::android.net.UrlQuerySanitizer.ParameterValuePair._ParameterValuePair7846 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "<init>", "(Landroid/net/UrlQuerySanitizer;Ljava/lang/String;Ljava/lang/String;)V");
				global::android.net.UrlQuerySanitizer.ParameterValuePair._mParameter7847 = @__env.GetFieldIDNoThrow(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "mParameter", "Ljava/lang/String;");
				global::android.net.UrlQuerySanitizer.ParameterValuePair._mValue7848 = @__env.GetFieldIDNoThrow(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "mValue", "Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.net.UrlQuerySanitizer.ValueSanitizer_))]
		public interface ValueSanitizer  : global::MonoJavaBridge.IJavaObject 
		{
			global::java.lang.String sanitize(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.net.UrlQuerySanitizer.ValueSanitizer))]
		public sealed partial class ValueSanitizer_ : java.lang.Object, ValueSanitizer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ValueSanitizer_()
			{
				InitJNI();
			}
			internal ValueSanitizer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _sanitize7849;
			 global::java.lang.String android.net.UrlQuerySanitizer.ValueSanitizer.sanitize(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.ValueSanitizer_._sanitize7849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass, global::android.net.UrlQuerySanitizer.ValueSanitizer_._sanitize7849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer$ValueSanitizer"));
				global::android.net.UrlQuerySanitizer.ValueSanitizer_._sanitize7849 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clear7850;
		protected virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._clear7850);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._clear7850);
		}
		internal static global::MonoJavaBridge.MethodId _getValue7851;
		public virtual global::java.lang.String getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getValue7851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getValue7851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _unescape7852;
		public virtual global::java.lang.String unescape(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._unescape7852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._unescape7852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isHexDigit7853;
		protected virtual bool isHexDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._isHexDigit7853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._isHexDigit7853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.net.UrlQuerySanitizer.ValueSanitizer UnregisteredParameterValueSanitizer
		{
			get
			{
				return getUnregisteredParameterValueSanitizer();
			}
			set
			{
				setUnregisteredParameterValueSanitizer(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUnregisteredParameterValueSanitizer7854;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getUnregisteredParameterValueSanitizer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer7854)) as android.net.UrlQuerySanitizer.ValueSanitizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer7854)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _setUnregisteredParameterValueSanitizer7855;
		public virtual void setUnregisteredParameterValueSanitizer(android.net.UrlQuerySanitizer.ValueSanitizer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer7855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer7855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AllIllegal
		{
			get
			{
				return getAllIllegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllIllegal7856;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllIllegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllIllegal7856)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AllButNulLegal
		{
			get
			{
				return getAllButNulLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllButNulLegal7857;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButNulLegal7857)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AllButWhitespaceLegal
		{
			get
			{
				return getAllButWhitespaceLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllButWhitespaceLegal7858;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButWhitespaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButWhitespaceLegal7858)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer UrlLegal
		{
			get
			{
				return getUrlLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrlLegal7859;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getUrlLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUrlLegal7859)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer UrlAndSpaceLegal
		{
			get
			{
				return getUrlAndSpaceLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrlAndSpaceLegal7860;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getUrlAndSpaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUrlAndSpaceLegal7860)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AmpLegal
		{
			get
			{
				return getAmpLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAmpLegal7861;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAmpLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAmpLegal7861)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AmpAndSpaceLegal
		{
			get
			{
				return getAmpAndSpaceLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAmpAndSpaceLegal7862;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAmpAndSpaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAmpAndSpaceLegal7862)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer SpaceLegal
		{
			get
			{
				return getSpaceLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpaceLegal7863;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getSpaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getSpaceLegal7863)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AllButNulAndAngleBracketsLegal
		{
			get
			{
				return getAllButNulAndAngleBracketsLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllButNulAndAngleBracketsLegal7864;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulAndAngleBracketsLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButNulAndAngleBracketsLegal7864)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _parseUrl7865;
		public virtual void parseUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._parseUrl7865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseUrl7865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseQuery7866;
		public virtual void parseQuery(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._parseQuery7866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseQuery7866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Set ParameterSet
		{
			get
			{
				return getParameterSet();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterSet7867;
		public virtual global::java.util.Set getParameterSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getParameterSet7867)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getParameterSet7867)) as java.util.Set;
		}
		public new global::java.util.List ParameterList
		{
			get
			{
				return getParameterList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterList7868;
		public virtual global::java.util.List getParameterList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getParameterList7868)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getParameterList7868)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _hasParameter7869;
		public virtual bool hasParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._hasParameter7869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._hasParameter7869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerParameter7870;
		public virtual void registerParameter(java.lang.String arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._registerParameter7870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._registerParameter7870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerParameters7871;
		public virtual void registerParameters(java.lang.String[] arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._registerParameters7871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._registerParameters7871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAllowUnregisteredParamaters7872;
		public virtual void setAllowUnregisteredParamaters(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters7872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters7872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAllowUnregisteredParamaters7873;
		public virtual bool getAllowUnregisteredParamaters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters7873);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters7873);
		}
		internal static global::MonoJavaBridge.MethodId _setPreferFirstRepeatedParameter7874;
		public virtual void setPreferFirstRepeatedParameter(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter7874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter7874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPreferFirstRepeatedParameter7875;
		public virtual bool getPreferFirstRepeatedParameter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter7875);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter7875);
		}
		internal static global::MonoJavaBridge.MethodId _parseEntry7876;
		protected virtual void parseEntry(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._parseEntry7876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseEntry7876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSanitizedEntry7877;
		protected virtual void addSanitizedEntry(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._addSanitizedEntry7877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._addSanitizedEntry7877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getValueSanitizer7878;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getValueSanitizer(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getValueSanitizer7878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getValueSanitizer7878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _getEffectiveValueSanitizer7879;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getEffectiveValueSanitizer(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer7879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer7879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _decodeHexDigit7880;
		protected virtual int decodeHexDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._decodeHexDigit7880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._decodeHexDigit7880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _UrlQuerySanitizer7881;
		public UrlQuerySanitizer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._UrlQuerySanitizer7881);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UrlQuerySanitizer7882;
		public UrlQuerySanitizer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._UrlQuerySanitizer7882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.UrlQuerySanitizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer"));
			global::android.net.UrlQuerySanitizer._clear7850 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "clear", "()V");
			global::android.net.UrlQuerySanitizer._getValue7851 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.UrlQuerySanitizer._unescape7852 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "unescape", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.UrlQuerySanitizer._isHexDigit7853 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "isHexDigit", "(C)Z");
			global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer7854 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUnregisteredParameterValueSanitizer", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer7855 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "setUnregisteredParameterValueSanitizer", "(Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V");
			global::android.net.UrlQuerySanitizer._getAllIllegal7856 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllIllegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAllButNulLegal7857 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAllButWhitespaceLegal7858 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButWhitespaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getUrlLegal7859 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUrlLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getUrlAndSpaceLegal7860 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUrlAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAmpLegal7861 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAmpLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAmpAndSpaceLegal7862 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAmpAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getSpaceLegal7863 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAllButNulAndAngleBracketsLegal7864 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulAndAngleBracketsLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._parseUrl7865 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "parseUrl", "(Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._parseQuery7866 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "parseQuery", "(Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._getParameterSet7867 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getParameterSet", "()Ljava/util/Set;");
			global::android.net.UrlQuerySanitizer._getParameterList7868 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getParameterList", "()Ljava/util/List;");
			global::android.net.UrlQuerySanitizer._hasParameter7869 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "hasParameter", "(Ljava/lang/String;)Z");
			global::android.net.UrlQuerySanitizer._registerParameter7870 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "registerParameter", "(Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V");
			global::android.net.UrlQuerySanitizer._registerParameters7871 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "registerParameters", "([Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V");
			global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters7872 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "setAllowUnregisteredParamaters", "(Z)V");
			global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters7873 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllowUnregisteredParamaters", "()Z");
			global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter7874 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "setPreferFirstRepeatedParameter", "(Z)V");
			global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter7875 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getPreferFirstRepeatedParameter", "()Z");
			global::android.net.UrlQuerySanitizer._parseEntry7876 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "parseEntry", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._addSanitizedEntry7877 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "addSanitizedEntry", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._getValueSanitizer7878 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer7879 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getEffectiveValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._decodeHexDigit7880 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "decodeHexDigit", "(C)I");
			global::android.net.UrlQuerySanitizer._UrlQuerySanitizer7881 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "()V");
			global::android.net.UrlQuerySanitizer._UrlQuerySanitizer7882 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
