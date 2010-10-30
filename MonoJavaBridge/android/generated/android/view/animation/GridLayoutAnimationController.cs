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
			internal static global::MonoJavaBridge.MethodId _AnimationParameters15683;
			public AnimationParameters() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters15683);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _column15684;
			public int column
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _column15684);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _row15685;
			public int row
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _row15685);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _columnsCount15686;
			public int columnsCount
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _columnsCount15686);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rowsCount15687;
			public int rowsCount
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _rowsCount15687);
				}
				set
				{
				}
			}
			static AnimationParameters()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/GridLayoutAnimationController$AnimationParameters"));
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._AnimationParameters15683 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "<init>", "()V");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._column15684 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "column", "I");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._row15685 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "row", "I");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._columnsCount15686 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "columnsCount", "I");
				global::android.view.animation.GridLayoutAnimationController.AnimationParameters._rowsCount15687 = @__env.GetFieldIDNoThrow(global::android.view.animation.GridLayoutAnimationController.AnimationParameters.staticClass, "rowsCount", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _willOverlap15688;
		public override bool willOverlap()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._willOverlap15688);
		}
		internal static global::MonoJavaBridge.MethodId _getDelayForView15689;
		protected override long getDelayForView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDelayForView15689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getColumnDelay15690;
		public virtual float getColumnDelay()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getColumnDelay15690);
		}
		internal static global::MonoJavaBridge.MethodId _setColumnDelay15691;
		public virtual void setColumnDelay(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setColumnDelay15691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRowDelay15692;
		public virtual float getRowDelay()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getRowDelay15692);
		}
		internal static global::MonoJavaBridge.MethodId _setRowDelay15693;
		public virtual void setRowDelay(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setRowDelay15693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDirection15694;
		public virtual int getDirection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDirection15694);
		}
		internal static global::MonoJavaBridge.MethodId _setDirection15695;
		public virtual void setDirection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setDirection15695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDirectionPriority15696;
		public virtual int getDirectionPriority()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._getDirectionPriority15696);
		}
		internal static global::MonoJavaBridge.MethodId _setDirectionPriority15697;
		public virtual void setDirectionPriority(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._setDirectionPriority15697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController15698;
		public GridLayoutAnimationController(android.view.animation.Animation arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController15699;
		public GridLayoutAnimationController(android.view.animation.Animation arg0, float arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridLayoutAnimationController15700;
		public GridLayoutAnimationController(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.GridLayoutAnimationController.staticClass, global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::android.view.animation.GridLayoutAnimationController._willOverlap15688 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "willOverlap", "()Z");
			global::android.view.animation.GridLayoutAnimationController._getDelayForView15689 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDelayForView", "(Landroid/view/View;)J");
			global::android.view.animation.GridLayoutAnimationController._getColumnDelay15690 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getColumnDelay", "()F");
			global::android.view.animation.GridLayoutAnimationController._setColumnDelay15691 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setColumnDelay", "(F)V");
			global::android.view.animation.GridLayoutAnimationController._getRowDelay15692 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getRowDelay", "()F");
			global::android.view.animation.GridLayoutAnimationController._setRowDelay15693 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setRowDelay", "(F)V");
			global::android.view.animation.GridLayoutAnimationController._getDirection15694 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirection", "()I");
			global::android.view.animation.GridLayoutAnimationController._setDirection15695 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirection", "(I)V");
			global::android.view.animation.GridLayoutAnimationController._getDirectionPriority15696 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "getDirectionPriority", "()I");
			global::android.view.animation.GridLayoutAnimationController._setDirectionPriority15697 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "setDirectionPriority", "(I)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15698 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15699 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/view/animation/Animation;FF)V");
			global::android.view.animation.GridLayoutAnimationController._GridLayoutAnimationController15700 = @__env.GetMethodIDNoThrow(global::android.view.animation.GridLayoutAnimationController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
