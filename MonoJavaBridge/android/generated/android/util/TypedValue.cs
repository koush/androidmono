namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypedValue : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TypedValue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.util.TypedValue.staticClass, "toString", "()Ljava/lang/String;", ref global::android.util.TypedValue._m0) as java.lang.String;
		}
		public new float Float
		{
			get
			{
				return getFloat();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual float getFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.util.TypedValue.staticClass, "getFloat", "()F", ref global::android.util.TypedValue._m1);
		}
		public new global::android.util.TypedValue To
		{
			set
			{
				setTo(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setTo(android.util.TypedValue arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.TypedValue.staticClass, "setTo", "(Landroid/util/TypedValue;)V", ref global::android.util.TypedValue._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual float getDimension(android.util.DisplayMetrics arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.util.TypedValue.staticClass, "getDimension", "(Landroid/util/DisplayMetrics;)F", ref global::android.util.TypedValue._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual float getFraction(float arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.util.TypedValue.staticClass, "getFraction", "(FF)F", ref global::android.util.TypedValue._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static float complexToFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TypedValue._m5.native == global::System.IntPtr.Zero)
				global::android.util.TypedValue._m5 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToFloat", "(I)F");
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static float complexToDimension(int arg0, android.util.DisplayMetrics arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TypedValue._m6.native == global::System.IntPtr.Zero)
				global::android.util.TypedValue._m6 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimension", "(ILandroid/util/DisplayMetrics;)F");
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static int complexToDimensionPixelOffset(int arg0, android.util.DisplayMetrics arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TypedValue._m7.native == global::System.IntPtr.Zero)
				global::android.util.TypedValue._m7 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimensionPixelOffset", "(ILandroid/util/DisplayMetrics;)I");
			return @__env.CallStaticIntMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static int complexToDimensionPixelSize(int arg0, android.util.DisplayMetrics arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TypedValue._m8.native == global::System.IntPtr.Zero)
				global::android.util.TypedValue._m8 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimensionPixelSize", "(ILandroid/util/DisplayMetrics;)I");
			return @__env.CallStaticIntMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static float complexToDimensionNoisy(int arg0, android.util.DisplayMetrics arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TypedValue._m9.native == global::System.IntPtr.Zero)
				global::android.util.TypedValue._m9 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToDimensionNoisy", "(ILandroid/util/DisplayMetrics;)F");
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static float applyDimension(int arg0, float arg1, android.util.DisplayMetrics arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TypedValue._m10.native == global::System.IntPtr.Zero)
				global::android.util.TypedValue._m10 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "applyDimension", "(IFLandroid/util/DisplayMetrics;)F");
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static float complexToFraction(int arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TypedValue._m11.native == global::System.IntPtr.Zero)
				global::android.util.TypedValue._m11 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "complexToFraction", "(IFF)F");
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.CharSequence coerceToString()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.util.TypedValue.staticClass, "coerceToString", "()Ljava/lang/CharSequence;", ref global::android.util.TypedValue._m12) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.lang.String coerceToString(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TypedValue._m13.native == global::System.IntPtr.Zero)
				global::android.util.TypedValue._m13 = @__env.GetStaticMethodIDNoThrow(global::android.util.TypedValue.staticClass, "coerceToString", "(II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public TypedValue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TypedValue._m14.native == global::System.IntPtr.Zero)
				global::android.util.TypedValue._m14 = @__env.GetMethodIDNoThrow(global::android.util.TypedValue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.TypedValue.staticClass, global::android.util.TypedValue._m14);
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
		internal static global::MonoJavaBridge.FieldId _type5450;
		public int type
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _type5450);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _string5451;
		public global::java.lang.CharSequence @string
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _string5451)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _data5452;
		public int data
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _data5452);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _assetCookie5453;
		public int assetCookie
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _assetCookie5453);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _resourceId5454;
		public int resourceId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _resourceId5454);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _changingConfigurations5455;
		public int changingConfigurations
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _changingConfigurations5455);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _density5456;
		public int density
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _density5456);
			}
			set
			{
			}
		}
		static TypedValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.TypedValue.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/TypedValue"));
			global::android.util.TypedValue._type5450 = @__env.GetFieldIDNoThrow(global::android.util.TypedValue.staticClass, "type", "I");
			global::android.util.TypedValue._string5451 = @__env.GetFieldIDNoThrow(global::android.util.TypedValue.staticClass, "@string", "Ljava/lang/CharSequence;");
			global::android.util.TypedValue._data5452 = @__env.GetFieldIDNoThrow(global::android.util.TypedValue.staticClass, "data", "I");
			global::android.util.TypedValue._assetCookie5453 = @__env.GetFieldIDNoThrow(global::android.util.TypedValue.staticClass, "assetCookie", "I");
			global::android.util.TypedValue._resourceId5454 = @__env.GetFieldIDNoThrow(global::android.util.TypedValue.staticClass, "resourceId", "I");
			global::android.util.TypedValue._changingConfigurations5455 = @__env.GetFieldIDNoThrow(global::android.util.TypedValue.staticClass, "changingConfigurations", "I");
			global::android.util.TypedValue._density5456 = @__env.GetFieldIDNoThrow(global::android.util.TypedValue.staticClass, "density", "I");
		}
	}
}
