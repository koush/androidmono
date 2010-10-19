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
		internal static global::MonoJavaBridge.MethodId _toString9181;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.TypedValue._toString9181)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._toString9181)) as java.lang.String;
		}
		public new float Float
		{
			get
			{
				return getFloat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFloat9182;
		public virtual float getFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.util.TypedValue._getFloat9182);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._getFloat9182);
		}
		internal static global::MonoJavaBridge.MethodId _setTo9183;
		public virtual void setTo(android.util.TypedValue arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.TypedValue._setTo9183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._setTo9183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDimension9184;
		public virtual float getDimension(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.util.TypedValue._getDimension9184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._getDimension9184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFraction9185;
		public virtual float getFraction(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.util.TypedValue._getFraction9185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._getFraction9185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _complexToFloat9186;
		public static float complexToFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToFloat9186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _complexToDimension9187;
		public static float complexToDimension(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimension9187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _complexToDimensionPixelOffset9188;
		public static int complexToDimensionPixelOffset(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimensionPixelOffset9188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _complexToDimensionPixelSize9189;
		public static int complexToDimensionPixelSize(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimensionPixelSize9189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _complexToDimensionNoisy9190;
		public static float complexToDimensionNoisy(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimensionNoisy9190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _applyDimension9191;
		public static float applyDimension(int arg0, float arg1, android.util.DisplayMetrics arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._applyDimension9191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _complexToFraction9192;
		public static float complexToFraction(int arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToFraction9192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _coerceToString9193;
		public virtual global::java.lang.CharSequence coerceToString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.util.TypedValue._coerceToString9193)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._coerceToString9193)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _coerceToString9194;
		public static global::java.lang.String coerceToString(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._coerceToString9194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TypedValue9195;
		public TypedValue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.TypedValue.staticClass, global::android.util.TypedValue._TypedValue9195);
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
		internal static global::MonoJavaBridge.FieldId _type9196;
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
		internal static global::MonoJavaBridge.FieldId _string9197;
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
		internal static global::MonoJavaBridge.FieldId _data9198;
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
		internal static global::MonoJavaBridge.FieldId _assetCookie9199;
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
		internal static global::MonoJavaBridge.FieldId _resourceId9200;
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
		internal static global::MonoJavaBridge.FieldId _changingConfigurations9201;
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
		internal static global::MonoJavaBridge.FieldId _density9202;
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
			global::android.util.TypedValue._toString9181 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "toString", "()Ljava/lang/String;");
			global::android.util.TypedValue._getFloat9182 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "getFloat", "()F");
			global::android.util.TypedValue._setTo9183 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "setTo", "(Landroid/util/TypedValue;)V");
			global::android.util.TypedValue._getDimension9184 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "getDimension", "(Landroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._getFraction9185 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "getFraction", "(FF)F");
			global::android.util.TypedValue._complexToFloat9186 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToFloat", "(I)F");
			global::android.util.TypedValue._complexToDimension9187 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimension", "(ILandroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._complexToDimensionPixelOffset9188 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimensionPixelOffset", "(ILandroid/util/DisplayMetrics;)I");
			global::android.util.TypedValue._complexToDimensionPixelSize9189 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimensionPixelSize", "(ILandroid/util/DisplayMetrics;)I");
			global::android.util.TypedValue._complexToDimensionNoisy9190 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimensionNoisy", "(ILandroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._applyDimension9191 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "applyDimension", "(IFLandroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._complexToFraction9192 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToFraction", "(IFF)F");
			global::android.util.TypedValue._coerceToString9193 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "coerceToString", "()Ljava/lang/CharSequence;");
			global::android.util.TypedValue._coerceToString9194 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "coerceToString", "(II)Ljava/lang/String;");
			global::android.util.TypedValue._TypedValue9195 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "<init>", "()V");
		}
	}
}
