namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class UrlQuerySanitizer : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static UrlQuerySanitizer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.UrlQuerySanitizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _sanitize4796; 
			public virtual global::java.lang.String sanitize(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize4796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize4796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _IllegalCharacterValueSanitizer4797; 
			public IllegalCharacterValueSanitizer(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._IllegalCharacterValueSanitizer4797, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
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
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._sanitize4796 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer._IllegalCharacterValueSanitizer4797 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.IllegalCharacterValueSanitizer.staticClass, "<init>", "(I)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class ParameterValuePair : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static ParameterValuePair() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.UrlQuerySanitizer.ParameterValuePair), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _ParameterValuePair4798; 
			public ParameterValuePair(android.net.UrlQuerySanitizer arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, global::android.net.UrlQuerySanitizer.ParameterValuePair._ParameterValuePair4798, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _mParameter4799; 
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
			internal static global::net.sf.jni4net.jni.FieldId _mValue4800; 
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass = @__class; 
				global::android.net.UrlQuerySanitizer.ParameterValuePair._ParameterValuePair4798 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.ParameterValuePair.staticClass, "<init>", "(Landroid/net/UrlQuerySanitizer;Ljava/lang/String;Ljava/lang/String;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ValueSanitizer 
		{ 
			global::java.lang.String sanitize(java.lang.String arg0); 
		} 

		public partial class ValueSanitizer_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __ValueSanitizer.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __ValueSanitizer : java.lang.Object, ValueSanitizer
		{ 
			internal static global::java.lang.Class staticClass; 
			static __ValueSanitizer() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.UrlQuerySanitizer.__ValueSanitizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.UrlQuerySanitizer.__ValueSanitizer(@__env); 
				} 
			} 
			internal __ValueSanitizer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _sanitize4801; 
			 global::java.lang.String android.net.UrlQuerySanitizer.ValueSanitizer.sanitize(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.__ValueSanitizer._sanitize4801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.__ValueSanitizer.staticClass, global::android.net.UrlQuerySanitizer.__ValueSanitizer._sanitize4801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.UrlQuerySanitizer.__ValueSanitizer.staticClass = @__class; 
				global::android.net.UrlQuerySanitizer.__ValueSanitizer._sanitize4801 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.__ValueSanitizer.staticClass, "android.net.UrlQuerySanitizer.ValueSanitizer.sanitize", "(Ljava/lang/String;)Ljava/lang/String;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear4802; 
		protected virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.UrlQuerySanitizer._clear4802); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._clear4802); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValue4803; 
		public virtual global::java.lang.String getValue(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.UrlQuerySanitizer._getValue4803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getValue4803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unescape4804; 
		public virtual global::java.lang.String unescape(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.UrlQuerySanitizer._unescape4804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._unescape4804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHexDigit4805; 
		protected virtual bool isHexDigit(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.UrlQuerySanitizer._isHexDigit4805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._isHexDigit4805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUnregisteredParameterValueSanitizer4806; 
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getUnregisteredParameterValueSanitizer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer4806)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer4806)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUnregisteredParameterValueSanitizer4807; 
		public virtual void setUnregisteredParameterValueSanitizer(android.net.UrlQuerySanitizer.ValueSanitizer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer4807, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer4807, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllIllegal4808; 
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllIllegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllIllegal4808)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllButNulLegal4809; 
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButNulLegal4809)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllButWhitespaceLegal4810; 
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButWhitespaceLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButWhitespaceLegal4810)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrlLegal4811; 
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getUrlLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUrlLegal4811)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrlAndSpaceLegal4812; 
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getUrlAndSpaceLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getUrlAndSpaceLegal4812)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAmpLegal4813; 
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAmpLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAmpLegal4813)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAmpAndSpaceLegal4814; 
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAmpAndSpaceLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAmpAndSpaceLegal4814)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpaceLegal4815; 
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getSpaceLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getSpaceLegal4815)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllButNulAndAngleBracketsLegal4816; 
		public static global::android.net.UrlQuerySanitizer.ValueSanitizer getAllButNulAndAngleBracketsLegal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallStaticObjectMethodPtr(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllButNulAndAngleBracketsLegal4816)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseUrl4817; 
		public virtual void parseUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.UrlQuerySanitizer._parseUrl4817, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseUrl4817, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseQuery4818; 
		public virtual void parseQuery(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.UrlQuerySanitizer._parseQuery4818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseQuery4818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParameterSet4819; 
		public virtual global::java.util.Set getParameterSet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.UrlQuerySanitizer._getParameterSet4819)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getParameterSet4819)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParameterList4820; 
		public virtual global::java.util.List getParameterList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.UrlQuerySanitizer._getParameterList4820)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getParameterList4820)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasParameter4821; 
		public virtual bool hasParameter(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.UrlQuerySanitizer._hasParameter4821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._hasParameter4821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerParameter4822; 
		public virtual void registerParameter(java.lang.String arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.UrlQuerySanitizer._registerParameter4822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._registerParameter4822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerParameters4823; 
		public virtual void registerParameters(java.lang.String[] arg0, android.net.UrlQuerySanitizer.ValueSanitizer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.UrlQuerySanitizer._registerParameters4823, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._registerParameters4823, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAllowUnregisteredParamaters4824; 
		public virtual void setAllowUnregisteredParamaters(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters4824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters4824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllowUnregisteredParamaters4825; 
		public virtual bool getAllowUnregisteredParamaters() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters4825); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters4825); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPreferFirstRepeatedParameter4826; 
		public virtual void setPreferFirstRepeatedParameter(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter4826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter4826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferFirstRepeatedParameter4827; 
		public virtual bool getPreferFirstRepeatedParameter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter4827); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter4827); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseEntry4828; 
		protected virtual void parseEntry(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.UrlQuerySanitizer._parseEntry4828, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._parseEntry4828, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSanitizedEntry4829; 
		protected virtual void addSanitizedEntry(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.UrlQuerySanitizer._addSanitizedEntry4829, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._addSanitizedEntry4829, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValueSanitizer4830; 
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getValueSanitizer(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.UrlQuerySanitizer._getValueSanitizer4830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getValueSanitizer4830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEffectiveValueSanitizer4831; 
		public virtual global::android.net.UrlQuerySanitizer.ValueSanitizer getEffectiveValueSanitizer(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer4831, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.net.UrlQuerySanitizer.ValueSanitizer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer4831, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeHexDigit4832; 
		protected virtual int decodeHexDigit(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.UrlQuerySanitizer._decodeHexDigit4832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._decodeHexDigit4832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UrlQuerySanitizer4833; 
		public UrlQuerySanitizer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._UrlQuerySanitizer4833, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UrlQuerySanitizer4834; 
		public UrlQuerySanitizer(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.UrlQuerySanitizer.staticClass, global::android.net.UrlQuerySanitizer._UrlQuerySanitizer4834, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.UrlQuerySanitizer.staticClass = @__class; 
			global::android.net.UrlQuerySanitizer._clear4802 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "clear", "()V"); 
			global::android.net.UrlQuerySanitizer._getValue4803 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.UrlQuerySanitizer._unescape4804 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "unescape", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.UrlQuerySanitizer._isHexDigit4805 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "isHexDigit", "(C)Z"); 
			global::android.net.UrlQuerySanitizer._getUnregisteredParameterValueSanitizer4806 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getUnregisteredParameterValueSanitizer", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._setUnregisteredParameterValueSanitizer4807 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "setUnregisteredParameterValueSanitizer", "(Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V"); 
			global::android.net.UrlQuerySanitizer._getAllIllegal4808 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAllIllegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getAllButNulLegal4809 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getAllButWhitespaceLegal4810 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAllButWhitespaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getUrlLegal4811 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getUrlLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getUrlAndSpaceLegal4812 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getUrlAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getAmpLegal4813 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAmpLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getAmpAndSpaceLegal4814 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAmpAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getSpaceLegal4815 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getAllButNulAndAngleBracketsLegal4816 = @__env.GetStaticMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAllButNulAndAngleBracketsLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._parseUrl4817 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "parseUrl", "(Ljava/lang/String;)V"); 
			global::android.net.UrlQuerySanitizer._parseQuery4818 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "parseQuery", "(Ljava/lang/String;)V"); 
			global::android.net.UrlQuerySanitizer._getParameterSet4819 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getParameterSet", "()Ljava/util/Set;"); 
			global::android.net.UrlQuerySanitizer._getParameterList4820 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getParameterList", "()Ljava/util/List;"); 
			global::android.net.UrlQuerySanitizer._hasParameter4821 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "hasParameter", "(Ljava/lang/String;)Z"); 
			global::android.net.UrlQuerySanitizer._registerParameter4822 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "registerParameter", "(Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V"); 
			global::android.net.UrlQuerySanitizer._registerParameters4823 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "registerParameters", "([Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V"); 
			global::android.net.UrlQuerySanitizer._setAllowUnregisteredParamaters4824 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "setAllowUnregisteredParamaters", "(Z)V"); 
			global::android.net.UrlQuerySanitizer._getAllowUnregisteredParamaters4825 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getAllowUnregisteredParamaters", "()Z"); 
			global::android.net.UrlQuerySanitizer._setPreferFirstRepeatedParameter4826 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "setPreferFirstRepeatedParameter", "(Z)V"); 
			global::android.net.UrlQuerySanitizer._getPreferFirstRepeatedParameter4827 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getPreferFirstRepeatedParameter", "()Z"); 
			global::android.net.UrlQuerySanitizer._parseEntry4828 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "parseEntry", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.net.UrlQuerySanitizer._addSanitizedEntry4829 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "addSanitizedEntry", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.net.UrlQuerySanitizer._getValueSanitizer4830 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._getEffectiveValueSanitizer4831 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "getEffectiveValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;"); 
			global::android.net.UrlQuerySanitizer._decodeHexDigit4832 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "decodeHexDigit", "(C)I"); 
			global::android.net.UrlQuerySanitizer._UrlQuerySanitizer4833 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "()V"); 
			global::android.net.UrlQuerySanitizer._UrlQuerySanitizer4834 = @__env.GetMethodID(global::android.net.UrlQuerySanitizer.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
