namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TypedValue : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static TypedValue()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.TypedValue), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.TypedValue(@__env);
			}
		}
		protected TypedValue(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString8331;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.TypedValue._toString8331));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._toString8331));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat8332;
		public virtual float getFloat() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.util.TypedValue._getFloat8332);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._getFloat8332);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTo8333;
		public virtual void setTo(android.util.TypedValue arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.TypedValue._setTo8333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._setTo8333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDimension8334;
		public virtual float getDimension(android.util.DisplayMetrics arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.util.TypedValue._getDimension8334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._getDimension8334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFraction8335;
		public virtual float getFraction(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.util.TypedValue._getFraction8335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._getFraction8335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _complexToFloat8336;
		public static float complexToFloat(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToFloat8336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _complexToDimension8337;
		public static float complexToDimension(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimension8337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _complexToDimensionPixelOffset8338;
		public static int complexToDimensionPixelOffset(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimensionPixelOffset8338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _complexToDimensionPixelSize8339;
		public static int complexToDimensionPixelSize(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimensionPixelSize8339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _complexToDimensionNoisy8340;
		public static float complexToDimensionNoisy(int arg0, android.util.DisplayMetrics arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToDimensionNoisy8340, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _applyDimension8341;
		public static float applyDimension(int arg0, float arg1, android.util.DisplayMetrics arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._applyDimension8341, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _complexToFraction8342;
		public static float complexToFraction(int arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.TypedValue.staticClass, global::android.util.TypedValue._complexToFraction8342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _coerceToString8343;
		public virtual global::java.lang.CharSequence coerceToString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.TypedValue._coerceToString8343));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.TypedValue.staticClass, global::android.util.TypedValue._coerceToString8343));
		}
		internal static global::net.sf.jni4net.jni.MethodId _coerceToString8344;
		public static global::java.lang.String coerceToString(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.TypedValue.staticClass, global::android.util.TypedValue._coerceToString8344, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TypedValue8345;
		public TypedValue()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.TypedValue.staticClass, global::android.util.TypedValue._TypedValue8345, this);
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
		internal static global::net.sf.jni4net.jni.FieldId _type8346;
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
		internal static global::net.sf.jni4net.jni.FieldId _string8347;
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
		internal static global::net.sf.jni4net.jni.FieldId _data8348;
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
		internal static global::net.sf.jni4net.jni.FieldId _assetCookie8349;
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
		internal static global::net.sf.jni4net.jni.FieldId _resourceId8350;
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
		internal static global::net.sf.jni4net.jni.FieldId _changingConfigurations8351;
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
		internal static global::net.sf.jni4net.jni.FieldId _density8352;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.TypedValue.staticClass = @__class;
			global::android.util.TypedValue._toString8331 = @__env.GetMethodID(global::android.util.TypedValue.staticClass, "toString", "()Ljava/lang/String;");
			global::android.util.TypedValue._getFloat8332 = @__env.GetMethodID(global::android.util.TypedValue.staticClass, "getFloat", "()F");
			global::android.util.TypedValue._setTo8333 = @__env.GetMethodID(global::android.util.TypedValue.staticClass, "setTo", "(Landroid/util/TypedValue;)V");
			global::android.util.TypedValue._getDimension8334 = @__env.GetMethodID(global::android.util.TypedValue.staticClass, "getDimension", "(Landroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._getFraction8335 = @__env.GetMethodID(global::android.util.TypedValue.staticClass, "getFraction", "(FF)F");
			global::android.util.TypedValue._complexToFloat8336 = @__env.GetStaticMethodID(global::android.util.TypedValue.staticClass, "complexToFloat", "(I)F");
			global::android.util.TypedValue._complexToDimension8337 = @__env.GetStaticMethodID(global::android.util.TypedValue.staticClass, "complexToDimension", "(ILandroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._complexToDimensionPixelOffset8338 = @__env.GetStaticMethodID(global::android.util.TypedValue.staticClass, "complexToDimensionPixelOffset", "(ILandroid/util/DisplayMetrics;)I");
			global::android.util.TypedValue._complexToDimensionPixelSize8339 = @__env.GetStaticMethodID(global::android.util.TypedValue.staticClass, "complexToDimensionPixelSize", "(ILandroid/util/DisplayMetrics;)I");
			global::android.util.TypedValue._complexToDimensionNoisy8340 = @__env.GetStaticMethodID(global::android.util.TypedValue.staticClass, "complexToDimensionNoisy", "(ILandroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._applyDimension8341 = @__env.GetStaticMethodID(global::android.util.TypedValue.staticClass, "applyDimension", "(IFLandroid/util/DisplayMetrics;)F");
			global::android.util.TypedValue._complexToFraction8342 = @__env.GetStaticMethodID(global::android.util.TypedValue.staticClass, "complexToFraction", "(IFF)F");
			global::android.util.TypedValue._coerceToString8343 = @__env.GetMethodID(global::android.util.TypedValue.staticClass, "coerceToString", "()Ljava/lang/CharSequence;");
			global::android.util.TypedValue._coerceToString8344 = @__env.GetStaticMethodID(global::android.util.TypedValue.staticClass, "coerceToString", "(II)Ljava/lang/String;");
			global::android.util.TypedValue._TypedValue8345 = @__env.GetMethodID(global::android.util.TypedValue.staticClass, "<init>", "()V");
		}
	}
}
