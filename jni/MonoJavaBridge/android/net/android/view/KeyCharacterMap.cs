namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class KeyCharacterMap : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static KeyCharacterMap() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.KeyCharacterMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.KeyCharacterMap(@__env); 
			} 
		} 
		protected KeyCharacterMap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class KeyData : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static KeyData() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.KeyCharacterMap.KeyData), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.KeyCharacterMap.KeyData(@__env); 
				} 
			} 
			protected KeyData(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _KeyData7344; 
			public KeyData()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.KeyCharacterMap.KeyData.staticClass, _KeyData7344, this); 
			} 
			public static int META_LENGTH
			{ 
				get 
				{ 
					return 4; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _displayLabel7345; 
			public char displayLabel
			{ 
				get 
				{ 
					return default(char); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _number7346; 
			public char number
			{ 
				get 
				{ 
					return default(char); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _meta7347; 
			public char[] meta
			{ 
				get 
				{ 
					return default(char[]); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.KeyCharacterMap.KeyData.staticClass = @__class; 
				global::android.view.KeyCharacterMap.KeyData._KeyData7344 = @__env.GetMethodID(global::android.view.KeyCharacterMap.KeyData.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get7348; 
		public virtual int get(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyCharacterMap)) 
				return @__env.CallIntMethod(this, _get7348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyCharacterMap.staticClass, _get7348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load7349; 
		public static android.view.KeyCharacterMap load(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.KeyCharacterMap>(@__env, @__env.CallStaticObjectMethodPtr(android.view.KeyCharacterMap.staticClass, _load7349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumber7350; 
		public virtual char getNumber(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyCharacterMap)) 
				return @__env.CallCharMethod(this, _getNumber7350, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.view.KeyCharacterMap.staticClass, _getNumber7350, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeadChar7351; 
		public static int getDeadChar(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.KeyCharacterMap.staticClass, _getDeadChar7351, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayLabel7352; 
		public virtual char getDisplayLabel(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyCharacterMap)) 
				return @__env.CallCharMethod(this, _getDisplayLabel7352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.view.KeyCharacterMap.staticClass, _getDisplayLabel7352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyData7353; 
		public virtual bool getKeyData(int arg0, android.view.KeyCharacterMap.KeyData arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyCharacterMap)) 
				return @__env.CallBooleanMethod(this, _getKeyData7353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyCharacterMap.staticClass, _getKeyData7353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatch7354; 
		public virtual char getMatch(int arg0, char[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyCharacterMap)) 
				return @__env.CallCharMethod(this, _getMatch7354, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.view.KeyCharacterMap.staticClass, _getMatch7354, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatch7355; 
		public virtual char getMatch(int arg0, char[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyCharacterMap)) 
				return @__env.CallCharMethod(this, _getMatch7355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.view.KeyCharacterMap.staticClass, _getMatch7355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPrintingKey7356; 
		public virtual bool isPrintingKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyCharacterMap)) 
				return @__env.CallBooleanMethod(this, _isPrintingKey7356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.KeyCharacterMap.staticClass, _isPrintingKey7356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEvents7357; 
		public virtual android.view.KeyEvent[] getEvents(char[] arg0) 
		{ 
			if (GetType() == typeof(android.view.KeyCharacterMap)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getEvents7357, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.KeyCharacterMap.staticClass, _getEvents7357, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyboardType7358; 
		public virtual int getKeyboardType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.KeyCharacterMap)) 
				return @__env.CallIntMethod(this, _getKeyboardType7358); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.KeyCharacterMap.staticClass, _getKeyboardType7358); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deviceHasKey7359; 
		public static bool deviceHasKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.view.KeyCharacterMap.staticClass, _deviceHasKey7359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deviceHasKeys7360; 
		public static bool[] deviceHasKeys(int[] arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.view.KeyCharacterMap.staticClass, _deviceHasKeys7360, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		public static int BUILT_IN_KEYBOARD
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int NUMERIC
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int PREDICTIVE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int ALPHA
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static char HEX_INPUT
		{ 
			get 
			{ 
				return '0'; 
			} 
		} 
		public static char PICKER_DIALOG_INPUT
		{ 
			get 
			{ 
				return '0'; 
			} 
		} 
		public static int COMBINING_ACCENT
		{ 
			get 
			{ 
				return -2147483648; 
			} 
		} 
		public static int COMBINING_ACCENT_MASK
		{ 
			get 
			{ 
				return 2147483647; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.KeyCharacterMap.staticClass = @__class; 
			global::android.view.KeyCharacterMap._get7348 = @__env.GetMethodID(global::android.view.KeyCharacterMap.staticClass, "get", "(II)I"); 
			global::android.view.KeyCharacterMap._load7349 = @__env.GetStaticMethodID(global::android.view.KeyCharacterMap.staticClass, "load", "(I)Landroid/view/KeyCharacterMap;"); 
			global::android.view.KeyCharacterMap._getNumber7350 = @__env.GetMethodID(global::android.view.KeyCharacterMap.staticClass, "getNumber", "(I)C"); 
			global::android.view.KeyCharacterMap._getDeadChar7351 = @__env.GetStaticMethodID(global::android.view.KeyCharacterMap.staticClass, "getDeadChar", "(II)I"); 
			global::android.view.KeyCharacterMap._getDisplayLabel7352 = @__env.GetMethodID(global::android.view.KeyCharacterMap.staticClass, "getDisplayLabel", "(I)C"); 
			global::android.view.KeyCharacterMap._getKeyData7353 = @__env.GetMethodID(global::android.view.KeyCharacterMap.staticClass, "getKeyData", "(ILandroid/view/KeyCharacterMap$KeyData;)Z"); 
			global::android.view.KeyCharacterMap._getMatch7354 = @__env.GetMethodID(global::android.view.KeyCharacterMap.staticClass, "getMatch", "(I[CI)C"); 
			global::android.view.KeyCharacterMap._getMatch7355 = @__env.GetMethodID(global::android.view.KeyCharacterMap.staticClass, "getMatch", "(I[C)C"); 
			global::android.view.KeyCharacterMap._isPrintingKey7356 = @__env.GetMethodID(global::android.view.KeyCharacterMap.staticClass, "isPrintingKey", "(I)Z"); 
			global::android.view.KeyCharacterMap._getEvents7357 = @__env.GetMethodID(global::android.view.KeyCharacterMap.staticClass, "getEvents", "([C)[Landroid/view/KeyEvent;"); 
			global::android.view.KeyCharacterMap._getKeyboardType7358 = @__env.GetMethodID(global::android.view.KeyCharacterMap.staticClass, "getKeyboardType", "()I"); 
			global::android.view.KeyCharacterMap._deviceHasKey7359 = @__env.GetStaticMethodID(global::android.view.KeyCharacterMap.staticClass, "deviceHasKey", "(I)Z"); 
			global::android.view.KeyCharacterMap._deviceHasKeys7360 = @__env.GetStaticMethodID(global::android.view.KeyCharacterMap.staticClass, "deviceHasKeys", "([I)[Z"); 
		} 
	} 
} 
