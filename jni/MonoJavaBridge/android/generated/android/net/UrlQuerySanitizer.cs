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
			internal static global::MonoJavaBridge.MethodId _sanitize5347;
			public virtual global::java.lang.String sanitize(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize5347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize5347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _IllegalCharacterValueSanitizer5348;
			public IllegalCharacterValueSanitizer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._IllegalCharacterValueSanitizer5348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize5347 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._IllegalCharacterValueSanitizer5348 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "<init>", "(I)V");
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
			internal static global::MonoJavaBridge.MethodId _ParameterValuePair5349;
			public ParameterValuePair(android.net.UrlQuerySanitizer arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, global::android.net.UrlQuerySanitizer.ParameterValuePair._ParameterValuePair5349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _mParameter5350;
			public global::java.lang.String mParameter
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mValue5351;
			public global::java.lang.String mValue
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer$ParameterValuePair"));
				global::android.net.UrlQuerySanitizer.ParameterValuePair._ParameterValuePair5349 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "<init>", "(Landroid/net/UrlQuerySanitizer;Ljava/lang/String;Ljava/lang/String;)V");
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
			internal static global::MonoJavaBridge.MethodId _sanitize5352;
			 global::java.lang.String android.net.UrlQuerySanitizer.ValueSanitizer.sanitize(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.ValueSanitizer_._sanitize5352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass, global::android.net.UrlQuerySanitizer.ValueSanitizer_._sanitize5352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer$ValueSanitizer"));
				global::android.net.UrlQuerySanitizer.ValueSanitizer_._sanitize5352 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.ValueSanitizer_.staticClass, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clear5353;
		protected virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._clear5353);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._clear5353);
		}
		internal static global::MonoJavaBridge.MethodId _getValue5354;
		public virtual global::java.lang.String getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getValue5354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getValue5354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _unescape5355;
		public virtual global::java.lang.String unescape(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._unescape5355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._unescape5355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isHexDigit5356;
		protected virtual bool isHexDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._isHexDigit5356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._isHexDigit5356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUnregisteredParameterValueSanitizer5357;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getUnregisteredParameterValueSanitizer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer5357)) as android.net.UrlQuerySanitizer.ValueSanitizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer5357)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _setUnregisteredParameterValueSanitizer5358;
		public virtual void setUnregisteredParameterValueSanitizer(android.net.UrlQuerySanitizer.ValueSanitizer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer5358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer5358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AllIllegal
		{
			get
			{
				return getAllIllegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllIllegal5359;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllIllegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllIllegal5359)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AllButNulLegal
		{
			get
			{
				return getAllButNulLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllButNulLegal5360;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButNulLegal5360)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AllButWhitespaceLegal
		{
			get
			{
				return getAllButWhitespaceLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllButWhitespaceLegal5361;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButWhitespaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButWhitespaceLegal5361)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer UrlLegal
		{
			get
			{
				return getUrlLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrlLegal5362;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getUrlLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUrlLegal5362)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer UrlAndSpaceLegal
		{
			get
			{
				return getUrlAndSpaceLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrlAndSpaceLegal5363;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getUrlAndSpaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUrlAndSpaceLegal5363)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AmpLegal
		{
			get
			{
				return getAmpLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAmpLegal5364;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAmpLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAmpLegal5364)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AmpAndSpaceLegal
		{
			get
			{
				return getAmpAndSpaceLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAmpAndSpaceLegal5365;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAmpAndSpaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAmpAndSpaceLegal5365)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer SpaceLegal
		{
			get
			{
				return getSpaceLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpaceLegal5366;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getSpaceLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getSpaceLegal5366)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer AllButNulAndAngleBracketsLegal
		{
			get
			{
				return getAllButNulAndAngleBracketsLegal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllButNulAndAngleBracketsLegal5367;
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulAndAngleBracketsLegal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallStaticObjectMethod(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButNulAndAngleBracketsLegal5367)) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _parseUrl5368;
		public virtual void parseUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._parseUrl5368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseUrl5368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseQuery5369;
		public virtual void parseQuery(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._parseQuery5369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseQuery5369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Set ParameterSet
		{
			get
			{
				return getParameterSet();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterSet5370;
		public virtual global::java.util.Set getParameterSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getParameterSet5370)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getParameterSet5370)) as java.util.Set;
		}
		public new global::java.util.List ParameterList
		{
			get
			{
				return getParameterList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterList5371;
		public virtual global::java.util.List getParameterList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getParameterList5371)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getParameterList5371)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _hasParameter5372;
		public virtual bool hasParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._hasParameter5372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._hasParameter5372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerParameter5373;
		public virtual void registerParameter(java.lang.String arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._registerParameter5373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._registerParameter5373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerParameters5374;
		public virtual void registerParameters(java.lang.String[] arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._registerParameters5374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._registerParameters5374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAllowUnregisteredParamaters5375;
		public virtual void setAllowUnregisteredParamaters(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters5375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters5375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAllowUnregisteredParamaters5376;
		public virtual bool getAllowUnregisteredParamaters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters5376);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters5376);
		}
		internal static global::MonoJavaBridge.MethodId _setPreferFirstRepeatedParameter5377;
		public virtual void setPreferFirstRepeatedParameter(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter5377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter5377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPreferFirstRepeatedParameter5378;
		public virtual bool getPreferFirstRepeatedParameter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter5378);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter5378);
		}
		internal static global::MonoJavaBridge.MethodId _parseEntry5379;
		protected virtual void parseEntry(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._parseEntry5379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseEntry5379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSanitizedEntry5380;
		protected virtual void addSanitizedEntry(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._addSanitizedEntry5380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._addSanitizedEntry5380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getValueSanitizer5381;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getValueSanitizer(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getValueSanitizer5381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getValueSanitizer5381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _getEffectiveValueSanitizer5382;
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getEffectiveValueSanitizer(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer5382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.net.UrlQuerySanitizer.ValueSanitizer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer5382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.UrlQuerySanitizer.ValueSanitizer;
		}
		internal static global::MonoJavaBridge.MethodId _decodeHexDigit5383;
		protected virtual int decodeHexDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer._decodeHexDigit5383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._decodeHexDigit5383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _UrlQuerySanitizer5384;
		public UrlQuerySanitizer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._UrlQuerySanitizer5384);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UrlQuerySanitizer5385;
		public UrlQuerySanitizer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._UrlQuerySanitizer5385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.UrlQuerySanitizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/UrlQuerySanitizer"));
			global::android.net.UrlQuerySanitizer._clear5353 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "clear", "()V");
			global::android.net.UrlQuerySanitizer._getValue5354 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.UrlQuerySanitizer._unescape5355 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "unescape", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.UrlQuerySanitizer._isHexDigit5356 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "isHexDigit", "(C)Z");
			global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer5357 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUnregisteredParameterValueSanitizer", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer5358 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "setUnregisteredParameterValueSanitizer", "(Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V");
			global::android.net.UrlQuerySanitizer._getAllIllegal5359 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllIllegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAllButNulLegal5360 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAllButWhitespaceLegal5361 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButWhitespaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getUrlLegal5362 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUrlLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getUrlAndSpaceLegal5363 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getUrlAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAmpLegal5364 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAmpLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAmpAndSpaceLegal5365 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAmpAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getSpaceLegal5366 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getAllButNulAndAngleBracketsLegal5367 = @__env.GetStaticMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulAndAngleBracketsLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._parseUrl5368 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "parseUrl", "(Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._parseQuery5369 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "parseQuery", "(Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._getParameterSet5370 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getParameterSet", "()Ljava/util/Set;");
			global::android.net.UrlQuerySanitizer._getParameterList5371 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getParameterList", "()Ljava/util/List;");
			global::android.net.UrlQuerySanitizer._hasParameter5372 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "hasParameter", "(Ljava/lang/String;)Z");
			global::android.net.UrlQuerySanitizer._registerParameter5373 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "registerParameter", "(Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V");
			global::android.net.UrlQuerySanitizer._registerParameters5374 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "registerParameters", "([Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V");
			global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters5375 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "setAllowUnregisteredParamaters", "(Z)V");
			global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters5376 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getAllowUnregisteredParamaters", "()Z");
			global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter5377 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "setPreferFirstRepeatedParameter", "(Z)V");
			global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter5378 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getPreferFirstRepeatedParameter", "()Z");
			global::android.net.UrlQuerySanitizer._parseEntry5379 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "parseEntry", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._addSanitizedEntry5380 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "addSanitizedEntry", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.net.UrlQuerySanitizer._getValueSanitizer5381 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer5382 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "getEffectiveValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;");
			global::android.net.UrlQuerySanitizer._decodeHexDigit5383 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "decodeHexDigit", "(C)I");
			global::android.net.UrlQuerySanitizer._UrlQuerySanitizer5384 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "()V");
			global::android.net.UrlQuerySanitizer._UrlQuerySanitizer5385 = @__env.GetMethodIDNoThrow(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
