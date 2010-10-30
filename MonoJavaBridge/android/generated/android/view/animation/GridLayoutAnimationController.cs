namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GridLayoutAnimationController : android.view.animation.LayoutAnimationController
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GridLayoutAnimationController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class AnimationParameters : android.view.animation.LayoutAnimationController.AnimationParameters
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AnimationParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public AnimationParameters() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.animation.GridLayoutAnimationController.AnimationParameters._m0.native == global::System.IntPtr.Zero)
					global::android.view.animation.GridLayoutAnimationController.AnimationParameters._m0 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.GridLayoutAnimationController.AnimationParameters._m0);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _column5888;
			public int column
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _column5888);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _row5889;
			public int row
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _row5889);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _columnsCount5890;
			public int columnsCount
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _columnsCount5890);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rowsCount5891;
			public int rowsCount
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _rowsCount5891);
				}
				set
				{
				}
			}
			static AnimationParameters()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/GridLayoutAnimationController$AnimationParameters"));
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._column5888 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "column", "I");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._row5889 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "row", "I");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._columnsCount5890 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "columnsCount", "I");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._rowsCount5891 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "rowsCount", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool willOverlap()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, "willOverlap", "()Z", ref global::android.view.animation.GridLayoutAnimationController._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override long getDelayForView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J", ref global::android.view.animation.GridLayoutAnimationController._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float ColumnDelay
		{
			get
			{
				return getColumnDelay();
			}
			set
			{
				setColumnDelay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual float getColumnDelay()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, "getColumnDelay", "()F", ref global::android.view.animation.GridLayoutAnimationController._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setColumnDelay(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, "setColumnDelay", "(F)V", ref global::android.view.animation.GridLayoutAnimationController._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float RowDelay
		{
			get
			{
				return getRowDelay();
			}
			set
			{
				setRowDelay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual float getRowDelay()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, "getRowDelay", "()F", ref global::android.view.animation.GridLayoutAnimationController._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setRowDelay(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, "setRowDelay", "(F)V", ref global::android.view.animation.GridLayoutAnimationController._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Direction
		{
			get
			{
				return getDirection();
			}
			set
			{
				setDirection(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getDirection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirection", "()I", ref global::android.view.animation.GridLayoutAnimationController._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setDirection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirection", "(I)V", ref global::android.view.animation.GridLayoutAnimationController._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DirectionPriority
		{
			get
			{
				return getDirectionPriority();
			}
			set
			{
				setDirectionPriority(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getDirectionPriority()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirectionPriority", "()I", ref global::android.view.animation.GridLayoutAnimationController._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setDirectionPriority(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirectionPriority", "(I)V", ref global::android.view.animation.GridLayoutAnimationController._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public GridLayoutAnimationController(android.view.animation.Animation arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.GridLayoutAnimationController._m10.native == global::System.IntPtr.Zero)
				global::android.view.animation.GridLayoutAnimationController._m10 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public GridLayoutAnimationController(android.view.animation.Animation arg0, float arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.GridLayoutAnimationController._m11.native == global::System.IntPtr.Zero)
				global::android.view.animation.GridLayoutAnimationController._m11 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public GridLayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.GridLayoutAnimationController._m12.native == global::System.IntPtr.Zero)
				global::android.view.animation.GridLayoutAnimationController._m12 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		static GridLayoutAnimationController()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.GridLayoutAnimationController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/GridLayoutAnimationController"));
		}
		internal static void InitJNI()
		{
		}
	}
}
