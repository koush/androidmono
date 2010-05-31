namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Gravity : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Gravity()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.Gravity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.Gravity(@__env);
			}
		}
		protected Gravity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _apply7776;
		public static void apply(int arg0, int arg1, int arg2, android.graphics.Rect arg3, android.graphics.Rect arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.Gravity.staticClass, global::android.view.Gravity._apply7776, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _apply7777;
		public static void apply(int arg0, int arg1, int arg2, android.graphics.Rect arg3, int arg4, int arg5, android.graphics.Rect arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.Gravity.staticClass, global::android.view.Gravity._apply7777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _applyDisplay7778;
		public static void applyDisplay(int arg0, android.graphics.Rect arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.Gravity.staticClass, global::android.view.Gravity._applyDisplay7778, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isVertical7779;
		public static bool isVertical(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.view.Gravity.staticClass, global::android.view.Gravity._isVertical7779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isHorizontal7780;
		public static bool isHorizontal(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.view.Gravity.staticClass, global::android.view.Gravity._isHorizontal7780, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Gravity7781;
		public Gravity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.Gravity.staticClass, global::android.view.Gravity._Gravity7781, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.Gravity.staticClass = @__class;
			global::android.view.Gravity._apply7776 = @__env.GetStaticMethodID(global::android.view.Gravity.staticClass, "apply", "(IIILandroid/graphics/Rect;Landroid/graphics/Rect;)V");
			global::android.view.Gravity._apply7777 = @__env.GetStaticMethodID(global::android.view.Gravity.staticClass, "apply", "(IIILandroid/graphics/Rect;IILandroid/graphics/Rect;)V");
			global::android.view.Gravity._applyDisplay7778 = @__env.GetStaticMethodID(global::android.view.Gravity.staticClass, "applyDisplay", "(ILandroid/graphics/Rect;Landroid/graphics/Rect;)V");
			global::android.view.Gravity._isVertical7779 = @__env.GetStaticMethodID(global::android.view.Gravity.staticClass, "isVertical", "(I)Z");
			global::android.view.Gravity._isHorizontal7780 = @__env.GetStaticMethodID(global::android.view.Gravity.staticClass, "isHorizontal", "(I)Z");
			global::android.view.Gravity._Gravity7781 = @__env.GetMethodID(global::android.view.Gravity.staticClass, "<init>", "()V");
		}
	}
}
