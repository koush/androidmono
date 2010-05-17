namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class UrlQuerySanitizer : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static UrlQuerySanitizer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.UrlQuerySanitizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.UrlQuerySanitizer(@__env); 
			} 
		} 
		protected UrlQuerySanitizer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class IllegalCharacterValueSanitizer : java.lang.Object, ValueSanitizer
		{ 
			internal static global::java.lang.Class staticClass; 
			static IllegalCharacterValueSanitizer() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer(@__env); 
				} 
			} 
			protected IllegalCharacterValueSanitizer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _sanitize4548; 
			public virtual java.lang.String sanitize(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _sanitize4548, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, _sanitize4548, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _IllegalCharacterValueSanitizer4549; 
			public IllegalCharacterValueSanitizer(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, _IllegalCharacterValueSanitizer4549, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass = @__class; 
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize4548 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._IllegalCharacterValueSanitizer4549 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "<init>", "(I)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class ParameterValuePair : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static ParameterValuePair() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.UrlQuerySanitizer.ParameterValuePair), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.UrlQuerySanitizer.ParameterValuePair(@__env); 
				} 
			} 
			protected ParameterValuePair(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ParameterValuePair4550; 
			public ParameterValuePair(android.net.UrlQuerySanitizer arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, _ParameterValuePair4550, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _mParameter4551; 
			public java.lang.String mParameter
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _mValue4552; 
			public java.lang.String mValue
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass = @__class; 
				global::android.net.UrlQuerySanitizer.ParameterValuePair._ParameterValuePair4550 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "<init>", "(Landroid/net/UrlQuerySanitizer;Ljava/lang/String;Ljava/lang/String;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ValueSanitizer 
		{ 
			java.lang.String sanitize(java.lang.String arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear4553; 
		protected virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				@__env.CallVoidMethod(this, _clear4553); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.UrlQuerySanitizer.staticClass, _clear4553); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValue4554; 
		public virtual java.lang.String getValue(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getValue4554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.UrlQuerySanitizer.staticClass, _getValue4554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unescape4555; 
		public virtual java.lang.String unescape(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _unescape4555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.UrlQuerySanitizer.staticClass, _unescape4555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHexDigit4556; 
		protected virtual bool isHexDigit(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return @__env.CallBooleanMethod(this, _isHexDigit4556, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.UrlQuerySanitizer.staticClass, _isHexDigit4556, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUnregisteredParameterValueSanitizer4557; 
		public virtual android.net.UrlQuerySanitizer.ValueSanitizer getUnregisteredParameterValueSanitizer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallObjectMethodPtr(this, _getUnregisteredParameterValueSanitizer4557)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.UrlQuerySanitizer.staticClass, _getUnregisteredParameterValueSanitizer4557)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUnregisteredParameterValueSanitizer4558; 
		public virtual void setUnregisteredParameterValueSanitizer(android.net.UrlQuerySanitizer.ValueSanitizer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				@__env.CallVoidMethod(this, _setUnregisteredParameterValueSanitizer4558, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.UrlQuerySanitizer.staticClass, _setUnregisteredParameterValueSanitizer4558, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllIllegal4559; 
		public static android.net.UrlQuerySanitizer.ValueSanitizer getAllIllegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, _getAllIllegal4559)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllButNulLegal4560; 
		public static android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, _getAllButNulLegal4560)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllButWhitespaceLegal4561; 
		public static android.net.UrlQuerySanitizer.ValueSanitizer getAllButWhitespaceLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, _getAllButWhitespaceLegal4561)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrlLegal4562; 
		public static android.net.UrlQuerySanitizer.ValueSanitizer getUrlLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, _getUrlLegal4562)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrlAndSpaceLegal4563; 
		public static android.net.UrlQuerySanitizer.ValueSanitizer getUrlAndSpaceLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, _getUrlAndSpaceLegal4563)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAmpLegal4564; 
		public static android.net.UrlQuerySanitizer.ValueSanitizer getAmpLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, _getAmpLegal4564)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAmpAndSpaceLegal4565; 
		public static android.net.UrlQuerySanitizer.ValueSanitizer getAmpAndSpaceLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, _getAmpAndSpaceLegal4565)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpaceLegal4566; 
		public static android.net.UrlQuerySanitizer.ValueSanitizer getSpaceLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, _getSpaceLegal4566)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllButNulAndAngleBracketsLegal4567; 
		public static android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulAndAngleBracketsLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, _getAllButNulAndAngleBracketsLegal4567)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseUrl4568; 
		public virtual void parseUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				@__env.CallVoidMethod(this, _parseUrl4568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.UrlQuerySanitizer.staticClass, _parseUrl4568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseQuery4569; 
		public virtual void parseQuery(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				@__env.CallVoidMethod(this, _parseQuery4569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.UrlQuerySanitizer.staticClass, _parseQuery4569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParameterSet4570; 
		public virtual java.util.Set getParameterSet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _getParameterSet4570)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.UrlQuerySanitizer.staticClass, _getParameterSet4570)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParameterList4571; 
		public virtual java.util.List getParameterList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getParameterList4571)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.UrlQuerySanitizer.staticClass, _getParameterList4571)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasParameter4572; 
		public virtual bool hasParameter(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return @__env.CallBooleanMethod(this, _hasParameter4572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.UrlQuerySanitizer.staticClass, _hasParameter4572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerParameter4573; 
		public virtual void registerParameter(java.lang.String arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				@__env.CallVoidMethod(this, _registerParameter4573, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.UrlQuerySanitizer.staticClass, _registerParameter4573, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerParameters4574; 
		public virtual void registerParameters(java.lang.String[] arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				@__env.CallVoidMethod(this, _registerParameters4574, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.UrlQuerySanitizer.staticClass, _registerParameters4574, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAllowUnregisteredParamaters4575; 
		public virtual void setAllowUnregisteredParamaters(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				@__env.CallVoidMethod(this, _setAllowUnregisteredParamaters4575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.UrlQuerySanitizer.staticClass, _setAllowUnregisteredParamaters4575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllowUnregisteredParamaters4576; 
		public virtual bool getAllowUnregisteredParamaters() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return @__env.CallBooleanMethod(this, _getAllowUnregisteredParamaters4576); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.UrlQuerySanitizer.staticClass, _getAllowUnregisteredParamaters4576); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPreferFirstRepeatedParameter4577; 
		public virtual void setPreferFirstRepeatedParameter(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				@__env.CallVoidMethod(this, _setPreferFirstRepeatedParameter4577, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.UrlQuerySanitizer.staticClass, _setPreferFirstRepeatedParameter4577, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferFirstRepeatedParameter4578; 
		public virtual bool getPreferFirstRepeatedParameter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return @__env.CallBooleanMethod(this, _getPreferFirstRepeatedParameter4578); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.UrlQuerySanitizer.staticClass, _getPreferFirstRepeatedParameter4578); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseEntry4579; 
		protected virtual void parseEntry(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				@__env.CallVoidMethod(this, _parseEntry4579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.UrlQuerySanitizer.staticClass, _parseEntry4579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSanitizedEntry4580; 
		protected virtual void addSanitizedEntry(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				@__env.CallVoidMethod(this, _addSanitizedEntry4580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.UrlQuerySanitizer.staticClass, _addSanitizedEntry4580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValueSanitizer4581; 
		public virtual android.net.UrlQuerySanitizer.ValueSanitizer getValueSanitizer(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallObjectMethodPtr(this, _getValueSanitizer4581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.UrlQuerySanitizer.staticClass, _getValueSanitizer4581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEffectiveValueSanitizer4582; 
		public virtual android.net.UrlQuerySanitizer.ValueSanitizer getEffectiveValueSanitizer(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallObjectMethodPtr(this, _getEffectiveValueSanitizer4582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.UrlQuerySanitizer.staticClass, _getEffectiveValueSanitizer4582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeHexDigit4583; 
		protected virtual int decodeHexDigit(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.UrlQuerySanitizer)) 
				return @__env.CallIntMethod(this, _decodeHexDigit4583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.UrlQuerySanitizer.staticClass, _decodeHexDigit4583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UrlQuerySanitizer4584; 
		public UrlQuerySanitizer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.UrlQuerySanitizer.staticClass, _UrlQuerySanitizer4584, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UrlQuerySanitizer4585; 
		public UrlQuerySanitizer(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.UrlQuerySanitizer.staticClass, _UrlQuerySanitizer4585, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.UrlQuerySanitizer.staticClass = @__class; 
			global::android.net.UrlQuerySanitizer._clear4553 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "clear", "()V"); 
			global::android.net.UrlQuerySanitizer._getValue4554 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.UrlQuerySanitizer._unescape4555 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "unescape", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.UrlQuerySanitizer._isHexDigit4556 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "isHexDigit", "(C)Z"); 
			global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer4557 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getUnregisteredParameterValueSanitizer", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer4558 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "setUnregisteredParameterValueSanitizer", "(Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V"); 
			global::android.net.UrlQuerySanitizer._getAllIllegal4559 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAllIllegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getAllButNulLegal4560 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getAllButWhitespaceLegal4561 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAllButWhitespaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getUrlLegal4562 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getUrlLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getUrlAndSpaceLegal4563 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getUrlAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getAmpLegal4564 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAmpLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getAmpAndSpaceLegal4565 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAmpAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getSpaceLegal4566 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getAllButNulAndAngleBracketsLegal4567 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulAndAngleBracketsLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._parseUrl4568 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "parseUrl", "(Ljava/lang/String;)V"); 
			global::android.net.UrlQuerySanitizer._parseQuery4569 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "parseQuery", "(Ljava/lang/String;)V"); 
			global::android.net.UrlQuerySanitizer._getParameterSet4570 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getParameterSet", "()Ljava/util/Set;"); 
			global::android.net.UrlQuerySanitizer._getParameterList4571 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getParameterList", "()Ljava/util/List;"); 
			global::android.net.UrlQuerySanitizer._hasParameter4572 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "hasParameter", "(Ljava/lang/String;)Z"); 
			global::android.net.UrlQuerySanitizer._registerParameter4573 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "registerParameter", "(Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V"); 
			global::android.net.UrlQuerySanitizer._registerParameters4574 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "registerParameters", "([Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V"); 
			global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters4575 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "setAllowUnregisteredParamaters", "(Z)V"); 
			global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters4576 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAllowUnregisteredParamaters", "()Z"); 
			global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter4577 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "setPreferFirstRepeatedParameter", "(Z)V"); 
			global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter4578 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getPreferFirstRepeatedParameter", "()Z"); 
			global::android.net.UrlQuerySanitizer._parseEntry4579 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "parseEntry", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.net.UrlQuerySanitizer._addSanitizedEntry4580 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "addSanitizedEntry", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.net.UrlQuerySanitizer._getValueSanitizer4581 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer4582 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getEffectiveValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._decodeHexDigit4583 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "decodeHexDigit", "(C)I"); 
			global::android.net.UrlQuerySanitizer._UrlQuerySanitizer4584 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "()V"); 
			global::android.net.UrlQuerySanitizer._UrlQuerySanitizer4585 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
