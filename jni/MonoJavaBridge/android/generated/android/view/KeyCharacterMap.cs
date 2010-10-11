namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyCharacterMap : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyCharacterMap()
		{
			InitJNI();
		}
		protected KeyCharacterMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class KeyData : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static KeyData()
			{
				InitJNI();
			}
			protected KeyData(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _KeyData8766;
			public KeyData()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.KeyCharacterMap.KeyData.staticClass, global::android.view.KeyCharacterMap.KeyData._KeyData8766);
				Init(@__env, handle);
			}
			public static int META_LENGTH
			{
				get
				{
					return 4;
				}
			}
			internal static global::MonoJavaBridge.FieldId _displayLabel8767;
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
			internal static global::MonoJavaBridge.FieldId _number8768;
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
			internal static global::MonoJavaBridge.FieldId _meta8769;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.KeyCharacterMap.KeyData.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyCharacterMap$KeyData"));
				global::android.view.KeyCharacterMap.KeyData._KeyData8766 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.KeyData.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize8770;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.KeyCharacterMap._finalize8770);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._finalize8770);
		}
		internal static global::MonoJavaBridge.MethodId _get8771;
		public virtual int get(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap._get8771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._get8771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load8772;
		public static global::android.view.KeyCharacterMap load(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._load8772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.KeyCharacterMap;
		}
		internal static global::MonoJavaBridge.MethodId _getNumber8773;
		public virtual char getNumber(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getNumber8773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getNumber8773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDeadChar8774;
		public static int getDeadChar(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getDeadChar8774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLabel8775;
		public virtual char getDisplayLabel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getDisplayLabel8775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getDisplayLabel8775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyData8776;
		public virtual bool getKeyData(int arg0, android.view.KeyCharacterMap.KeyData arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getKeyData8776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getKeyData8776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMatch8777;
		public virtual char getMatch(int arg0, char[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getMatch8777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getMatch8777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getMatch8778;
		public virtual char getMatch(int arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getMatch8778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getMatch8778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isPrintingKey8779;
		public virtual bool isPrintingKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap._isPrintingKey8779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._isPrintingKey8779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEvents8780;
		public virtual global::android.view.KeyEvent[] getEvents(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.KeyEvent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getEvents8780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.KeyEvent[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.KeyEvent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getEvents8780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.KeyEvent[];
		}
		internal static global::MonoJavaBridge.MethodId _getKeyboardType8781;
		public virtual int getKeyboardType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap._getKeyboardType8781);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._getKeyboardType8781);
		}
		internal static global::MonoJavaBridge.MethodId _deviceHasKey8782;
		public static bool deviceHasKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._deviceHasKey8782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deviceHasKeys8783;
		public static bool[] deviceHasKeys(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(android.view.KeyCharacterMap.staticClass, global::android.view.KeyCharacterMap._deviceHasKeys8783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.KeyCharacterMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/KeyCharacterMap"));
			global::android.view.KeyCharacterMap._finalize8770 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "finalize", "()V");
			global::android.view.KeyCharacterMap._get8771 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "get", "(II)I");
			global::android.view.KeyCharacterMap._load8772 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "load", "(I)Landroid/view/KeyCharacterMap;");
			global::android.view.KeyCharacterMap._getNumber8773 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getNumber", "(I)C");
			global::android.view.KeyCharacterMap._getDeadChar8774 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getDeadChar", "(II)I");
			global::android.view.KeyCharacterMap._getDisplayLabel8775 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getDisplayLabel", "(I)C");
			global::android.view.KeyCharacterMap._getKeyData8776 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getKeyData", "(ILandroid/view/KeyCharacterMap$KeyData;)Z");
			global::android.view.KeyCharacterMap._getMatch8777 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getMatch", "(I[CI)C");
			global::android.view.KeyCharacterMap._getMatch8778 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getMatch", "(I[C)C");
			global::android.view.KeyCharacterMap._isPrintingKey8779 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "isPrintingKey", "(I)Z");
			global::android.view.KeyCharacterMap._getEvents8780 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getEvents", "([C)[Landroid/view/KeyEvent;");
			global::android.view.KeyCharacterMap._getKeyboardType8781 = @__env.GetMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "getKeyboardType", "()I");
			global::android.view.KeyCharacterMap._deviceHasKey8782 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "deviceHasKey", "(I)Z");
			global::android.view.KeyCharacterMap._deviceHasKeys8783 = @__env.GetStaticMethodIDNoThrow(global::android.view.KeyCharacterMap.staticClass, "deviceHasKeys", "([I)[Z");
		}
	}
}
