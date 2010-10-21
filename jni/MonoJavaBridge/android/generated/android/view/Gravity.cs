namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Gravity : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Gravity()
		{
			InitJNI();
		}
		protected Gravity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _apply13990;
		public static void apply(int arg0, int arg1, int arg2, android.graphics.Rect arg3, android.graphics.Rect arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.Gravity.staticClass, global::android.view.Gravity._apply13990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _apply13991;
		public static void apply(int arg0, int arg1, int arg2, android.graphics.Rect arg3, int arg4, int arg5, android.graphics.Rect arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.Gravity.staticClass, global::android.view.Gravity._apply13991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _applyDisplay13992;
		public static void applyDisplay(int arg0, android.graphics.Rect arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.Gravity.staticClass, global::android.view.Gravity._applyDisplay13992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isVertical13993;
		public static bool isVertical(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.view.Gravity.staticClass, global::android.view.Gravity._isVertical13993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHorizontal13994;
		public static bool isHorizontal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.view.Gravity.staticClass, global::android.view.Gravity._isHorizontal13994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Gravity13995;
		public Gravity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Gravity.staticClass, global::android.view.Gravity._Gravity13995);
			Init(@__env, handle);
		}
		public static int NO_GRAVITY
		{
			get
			{
				return 0;
			}
		}
		public static int AXIS_SPECIFIED
		{
			get
			{
				return 1;
			}
		}
		public static int AXIS_PULL_BEFORE
		{
			get
			{
				return 2;
			}
		}
		public static int AXIS_PULL_AFTER
		{
			get
			{
				return 4;
			}
		}
		public static int AXIS_CLIP
		{
			get
			{
				return 8;
			}
		}
		public static int AXIS_X_SHIFT
		{
			get
			{
				return 0;
			}
		}
		public static int AXIS_Y_SHIFT
		{
			get
			{
				return 4;
			}
		}
		public static int TOP
		{
			get
			{
				return 48;
			}
		}
		public static int BOTTOM
		{
			get
			{
				return 80;
			}
		}
		public static int LEFT
		{
			get
			{
				return 3;
			}
		}
		public static int RIGHT
		{
			get
			{
				return 5;
			}
		}
		public static int CENTER_VERTICAL
		{
			get
			{
				return 16;
			}
		}
		public static int FILL_VERTICAL
		{
			get
			{
				return 112;
			}
		}
		public static int CENTER_HORIZONTAL
		{
			get
			{
				return 1;
			}
		}
		public static int FILL_HORIZONTAL
		{
			get
			{
				return 7;
			}
		}
		public static int CENTER
		{
			get
			{
				return 17;
			}
		}
		public static int FILL
		{
			get
			{
				return 119;
			}
		}
		public static int CLIP_VERTICAL
		{
			get
			{
				return 128;
			}
		}
		public static int CLIP_HORIZONTAL
		{
			get
			{
				return 8;
			}
		}
		public static int HORIZONTAL_GRAVITY_MASK
		{
			get
			{
				return 7;
			}
		}
		public static int VERTICAL_GRAVITY_MASK
		{
			get
			{
				return 112;
			}
		}
		public static int DISPLAY_CLIP_VERTICAL
		{
			get
			{
				return 268435456;
			}
		}
		public static int DISPLAY_CLIP_HORIZONTAL
		{
			get
			{
				return 16777216;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Gravity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Gravity"));
			global::android.view.Gravity._apply13990 = @__env.GetStaticMethodIDNoThrow(global::android.view.Gravity.staticClass, "apply", "(IIILandroid/graphics/Rect;Landroid/graphics/Rect;)V");
			global::android.view.Gravity._apply13991 = @__env.GetStaticMethodIDNoThrow(global::android.view.Gravity.staticClass, "apply", "(IIILandroid/graphics/Rect;IILandroid/graphics/Rect;)V");
			global::android.view.Gravity._applyDisplay13992 = @__env.GetStaticMethodIDNoThrow(global::android.view.Gravity.staticClass, "applyDisplay", "(ILandroid/graphics/Rect;Landroid/graphics/Rect;)V");
			global::android.view.Gravity._isVertical13993 = @__env.GetStaticMethodIDNoThrow(global::android.view.Gravity.staticClass, "isVertical", "(I)Z");
			global::android.view.Gravity._isHorizontal13994 = @__env.GetStaticMethodIDNoThrow(global::android.view.Gravity.staticClass, "isHorizontal", "(I)Z");
			global::android.view.Gravity._Gravity13995 = @__env.GetMethodIDNoThrow(global::android.view.Gravity.staticClass, "<init>", "()V");
		}
	}
}
