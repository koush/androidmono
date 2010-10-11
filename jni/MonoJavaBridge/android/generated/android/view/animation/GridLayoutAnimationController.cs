namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GridLayoutAnimationController : android.view.animation.LayoutAnimationController
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GridLayoutAnimationController()
		{
			InitJNI();
		}
		protected GridLayoutAnimationController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class AnimationParameters : android.view.animation.LayoutAnimationController.AnimationParameters
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AnimationParameters()
			{
				InitJNI();
			}
			protected AnimationParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _AnimationParameters9998;
			public AnimationParameters()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters9998);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _column9999;
			public int column
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _row10000;
			public int row
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _columnsCount10001;
			public int columnsCount
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rowsCount10002;
			public int rowsCount
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
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/GridLayoutAnimationController$AnimationParameters"));
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters9998 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _willOverlap10003;
		public override bool willOverlap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._willOverlap10003);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._willOverlap10003);
		}
		internal static global::MonoJavaBridge.MethodId _getDelayForView10004;
		protected override long getDelayForView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getDelayForView10004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDelayForView10004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnDelay10005;
		public virtual float getColumnDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getColumnDelay10005);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getColumnDelay10005);
		}
		internal static global::MonoJavaBridge.MethodId _setColumnDelay10006;
		public virtual void setColumnDelay(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setColumnDelay10006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setColumnDelay10006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRowDelay10007;
		public virtual float getRowDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getRowDelay10007);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getRowDelay10007);
		}
		internal static global::MonoJavaBridge.MethodId _setRowDelay10008;
		public virtual void setRowDelay(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setRowDelay10008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setRowDelay10008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDirection10009;
		public virtual int getDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getDirection10009);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDirection10009);
		}
		internal static global::MonoJavaBridge.MethodId _setDirection10010;
		public virtual void setDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setDirection10010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setDirection10010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDirectionPriority10011;
		public virtual int getDirectionPriority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._getDirectionPriority10011);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDirectionPriority10011);
		}
		internal static global::MonoJavaBridge.MethodId _setDirectionPriority10012;
		public virtual void setDirectionPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController._setDirectionPriority10012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setDirectionPriority10012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController10013;
		public GridLayoutAnimationController(android.view.animation.Animation arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController10014;
		public GridLayoutAnimationController(android.view.animation.Animation arg0, float arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController10015;
		public GridLayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int DIRECTION_LEFT_TO_RIGHT
		{
			get
			{
				return 0;
			}
		}
		public static int DIRECTION_RIGHT_TO_LEFT
		{
			get
			{
				return 1;
			}
		}
		public static int DIRECTION_TOP_TO_BOTTOM
		{
			get
			{
				return 0;
			}
		}
		public static int DIRECTION_BOTTOM_TO_TOP
		{
			get
			{
				return 2;
			}
		}
		public static int DIRECTION_HORIZONTAL_MASK
		{
			get
			{
				return 1;
			}
		}
		public static int DIRECTION_VERTICAL_MASK
		{
			get
			{
				return 2;
			}
		}
		public static int PRIORITY_NONE
		{
			get
			{
				return 0;
			}
		}
		public static int PRIORITY_COLUMN
		{
			get
			{
				return 1;
			}
		}
		public static int PRIORITY_ROW
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.GridLayoutAnimationController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/GridLayoutAnimationController"));
			global::android.view.animation.GridLayoutAnimationController._willOverlap10003 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "willOverlap", "()Z");
			global::android.view.animation.GridLayoutAnimationController._getDelayForView10004 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J");
			global::android.view.animation.GridLayoutAnimationController._getColumnDelay10005 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getColumnDelay", "()F");
			global::android.view.animation.GridLayoutAnimationController._setColumnDelay10006 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setColumnDelay", "(F)V");
			global::android.view.animation.GridLayoutAnimationController._getRowDelay10007 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getRowDelay", "()F");
			global::android.view.animation.GridLayoutAnimationController._setRowDelay10008 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setRowDelay", "(F)V");
			global::android.view.animation.GridLayoutAnimationController._getDirection10009 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirection", "()I");
			global::android.view.animation.GridLayoutAnimationController._setDirection10010 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirection", "(I)V");
			global::android.view.animation.GridLayoutAnimationController._getDirectionPriority10011 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirectionPriority", "()I");
			global::android.view.animation.GridLayoutAnimationController._setDirectionPriority10012 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirectionPriority", "(I)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10013 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10014 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;FF)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController10015 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
