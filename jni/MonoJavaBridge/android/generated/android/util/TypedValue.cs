namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypedValue : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TypedValue()
		{
			InitJNI();
		}
		protected TypedValue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString8635;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.TypedValue._toString8635)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._toString8635)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat8636;
		public virtual float getFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.util.TypedValue._getFloat8636);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._getFloat8636);
		}
		internal static global::MonoJavaBridge.MethodId _setTo8637;
		public virtual void setTo(android.util.TypedValue arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TypedValue._setTo8637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._setTo8637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDimension8638;
		public virtual float getDimension(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.util.TypedValue._getDimension8638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._getDimension8638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFraction8639;
		public virtual float getFraction(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.util.TypedValue._getFraction8639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._getFraction8639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _complexToFloat8640;
		public static float complexToFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToFloat8640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _complexToDimension8641;
		public static float complexToDimension(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimension8641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _complexToDimensionPixelOffset8642;
		public static int complexToDimensionPixelOffset(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimensionPixelOffset8642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _complexToDimensionPixelSize8643;
		public static int complexToDimensionPixelSize(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimensionPixelSize8643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _complexToDimensionNoisy8644;
		public static float complexToDimensionNoisy(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimensionNoisy8644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _applyDimension8645;
		public static float applyDimension(int arg0, float arg1, android.util.DisplayMetrics arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._applyDimension8645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _complexToFraction8646;
		public static float complexToFraction(int arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToFraction8646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _coerceToString8647;
		public virtual global::java.lang.CharSequence coerceToString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.util.TypedValue._coerceToString8647)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._coerceToString8647)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _coerceToString8648;
		public static global::java.lang.String coerceToString(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._coerceToString8648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TypedValue8649;
		public TypedValue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.TypedValue.staticClass, global::android.util.TypedValue._TypedValue8649);
			Init(@__env, handle);
		}
		public static int TYPE_NULL
		{
			get
			{
				return 0;
			}
		}
		public static int TYPE_REFERENCE
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_ATTRIBUTE
		{
			get
			{
				return 2;
			}
		}
		public static int TYPE_STRING
		{
			get
			{
				return 3;
			}
		}
		public static int TYPE_FLOAT
		{
			get
			{
				return 4;
			}
		}
		public static int TYPE_DIMENSION
		{
			get
			{
				return 5;
			}
		}
		public static int TYPE_FRACTION
		{
			get
			{
				return 6;
			}
		}
		public static int TYPE_FIRST_INT
		{
			get
			{
				return 16;
			}
		}
		public static int TYPE_INT_DEC
		{
			get
			{
				return 16;
			}
		}
		public static int TYPE_INT_HEX
		{
			get
			{
				return 17;
			}
		}
		public static int TYPE_INT_BOOLEAN
		{
			get
			{
				return 18;
			}
		}
		public static int TYPE_FIRST_COLOR_INT
		{
			get
			{
				return 28;
			}
		}
		public static int TYPE_INT_COLOR_ARGB8
		{
			get
			{
				return 28;
			}
		}
		public static int TYPE_INT_COLOR_RGB8
		{
			get
			{
				return 29;
			}
		}
		public static int TYPE_INT_COLOR_ARGB4
		{
			get
			{
				return 30;
			}
		}
		public static int TYPE_INT_COLOR_RGB4
		{
			get
			{
				return 31;
			}
		}
		public static int TYPE_LAST_COLOR_INT
		{
			get
			{
				return 31;
			}
		}
		public static int TYPE_LAST_INT
		{
			get
			{
				return 31;
			}
		}
		public static int COMPLEX_UNIT_SHIFT
		{
			get
			{
				return 0;
			}
		}
		public static int COMPLEX_UNIT_MASK
		{
			get
			{
				return 15;
			}
		}
		public static int COMPLEX_UNIT_PX
		{
			get
			{
				return 0;
			}
		}
		public static int COMPLEX_UNIT_DIP
		{
			get
			{
				return 1;
			}
		}
		public static int COMPLEX_UNIT_SP
		{
			get
			{
				return 2;
			}
		}
		public static int COMPLEX_UNIT_PT
		{
			get
			{
				return 3;
			}
		}
		public static int COMPLEX_UNIT_IN
		{
			get
			{
				return 4;
			}
		}
		public static int COMPLEX_UNIT_MM
		{
			get
			{
				return 5;
			}
		}
		public static int COMPLEX_UNIT_FRACTION
		{
			get
			{
				return 0;
			}
		}
		public static int COMPLEX_UNIT_FRACTION_PARENT
		{
			get
			{
				return 1;
			}
		}
		public static int COMPLEX_RADIX_SHIFT
		{
			get
			{
				return 4;
			}
		}
		public static int COMPLEX_RADIX_MASK
		{
			get
			{
				return 3;
			}
		}
		public static int COMPLEX_RADIX_23p0
		{
			get
			{
				return 0;
			}
		}
		public static int COMPLEX_RADIX_16p7
		{
			get
			{
				return 1;
			}
		}
		public static int COMPLEX_RADIX_8p15
		{
			get
			{
				return 2;
			}
		}
		public static int COMPLEX_RADIX_0p23
		{
			get
			{
				return 3;
			}
		}
		public static int COMPLEX_MANTISSA_SHIFT
		{
			get
			{
				return 8;
			}
		}
		public static int COMPLEX_MANTISSA_MASK
		{
			get
			{
				return 16777215;
			}
		}
		public static int DENSITY_DEFAULT
		{
			get
			{
				return 0;
			}
		}
		public static int DENSITY_NONE
		{
			get
			{
				return 65535;
			}
		}
		internal static global::MonoJavaBridge.FieldId _type8650;
		public int type
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _string8651;
		public global::java.lang.CharSequence @string
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _data8652;
		public int data
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _assetCookie8653;
		public int assetCookie
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _resourceId8654;
		public int resourceId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _changingConfigurations8655;
		public int changingConfigurations
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _density8656;
		public int density
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.TypedValue.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/TypedValue"));
			global::android.util.TypedValue._toString8635 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "toString", "()Ljava/lang/String;");
			global::android.util.TypedValue._getFloat8636 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "getFloat", "()F");
			global::android.util.TypedValue._setTo8637 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "setTo", "(Landroid/util/TypedValue;)V");
			global::android.util.TypedValue._getDimension8638 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "getDimension", "(Landroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._getFraction8639 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "getFraction", "(FF)F");
			global::android.util.TypedValue._complexToFloat8640 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToFloat", "(I)F");
			global::android.util.TypedValue._complexToDimension8641 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimension", "(ILandroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._complexToDimensionPixelOffset8642 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimensionPixelOffset", "(ILandroid/util/DisplayMetrics;)I");
			global::android.util.TypedValue._complexToDimensionPixelSize8643 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimensionPixelSize", "(ILandroid/util/DisplayMetrics;)I");
			global::android.util.TypedValue._complexToDimensionNoisy8644 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimensionNoisy", "(ILandroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._applyDimension8645 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "applyDimension", "(IFLandroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._complexToFraction8646 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToFraction", "(IFF)F");
			global::android.util.TypedValue._coerceToString8647 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "coerceToString", "()Ljava/lang/CharSequence;");
			global::android.util.TypedValue._coerceToString8648 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "coerceToString", "(II)Ljava/lang/String;");
			global::android.util.TypedValue._TypedValue8649 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "<init>", "()V");
		}
	}
}
