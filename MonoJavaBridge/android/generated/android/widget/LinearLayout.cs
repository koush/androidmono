namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinearLayout : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LinearLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _debug17294;
			public virtual global::java.lang.String debug(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._debug17294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17295;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams17295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17296;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams17296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17297;
			public LayoutParams(int arg0, int arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams17297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17298;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams17298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17299;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams17299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _weight17300;
			public float weight
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _weight17300);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _gravity17301;
			public int gravity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _gravity17301);
				}
				set
				{
				}
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.LinearLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/LinearLayout$LayoutParams"));
				global::android.widget.LinearLayout.LayoutParams._debug17294 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams17295 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams17296 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams17297 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams17298 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams17299 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::android.widget.LinearLayout.LayoutParams._weight17300 = @__env.GetFieldIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "weight", "F");
				global::android.widget.LinearLayout.LayoutParams._gravity17301 = @__env.GetFieldIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "gravity", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		public new int Gravity
		{
			set
			{
				setGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGravity17302;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setGravity17302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17303;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._onLayout17303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline17304;
		public override int getBaseline()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getBaseline17304);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17305;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._onMeasure17305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17306;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._checkLayoutParams17306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17307;
		public virtual global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateLayoutParams17307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17308;
		protected virtual global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateLayoutParams17308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17309;
		protected virtual global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateDefaultLayoutParams17309)) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _isBaselineAligned17310;
		public virtual bool isBaselineAligned()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._isBaselineAligned17310);
		}
		public new bool BaselineAligned
		{
			set
			{
				setBaselineAligned(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBaselineAligned17311;
		public virtual void setBaselineAligned(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setBaselineAligned17311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BaselineAlignedChildIndex
		{
			get
			{
				return getBaselineAlignedChildIndex();
			}
			set
			{
				setBaselineAlignedChildIndex(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaselineAlignedChildIndex17312;
		public virtual int getBaselineAlignedChildIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getBaselineAlignedChildIndex17312);
		}
		internal static global::MonoJavaBridge.MethodId _setBaselineAlignedChildIndex17313;
		public virtual void setBaselineAlignedChildIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setBaselineAlignedChildIndex17313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float WeightSum
		{
			get
			{
				return getWeightSum();
			}
			set
			{
				setWeightSum(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWeightSum17314;
		public virtual float getWeightSum()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getWeightSum17314);
		}
		internal static global::MonoJavaBridge.MethodId _setWeightSum17315;
		public virtual void setWeightSum(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setWeightSum17315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOrientation17316;
		public virtual void setOrientation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setOrientation17316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Orientation
		{
			get
			{
				return getOrientation();
			}
			set
			{
				setOrientation(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOrientation17317;
		public virtual int getOrientation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getOrientation17317);
		}
		public new int HorizontalGravity
		{
			set
			{
				setHorizontalGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalGravity17318;
		public virtual void setHorizontalGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setHorizontalGravity17318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VerticalGravity
		{
			set
			{
				setVerticalGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalGravity17319;
		public virtual void setVerticalGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setVerticalGravity17319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LinearLayout17320;
		public LinearLayout(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._LinearLayout17320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinearLayout17321;
		public LinearLayout(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._LinearLayout17321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int HORIZONTAL
		{
			get
			{
				return 0;
			}
		}
		public static int VERTICAL
		{
			get
			{
				return 1;
			}
		}
		static LinearLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.LinearLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/LinearLayout"));
			global::android.widget.LinearLayout._setGravity17302 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setGravity", "(I)V");
			global::android.widget.LinearLayout._onLayout17303 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.LinearLayout._getBaseline17304 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getBaseline", "()I");
			global::android.widget.LinearLayout._onMeasure17305 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.LinearLayout._checkLayoutParams17306 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.LinearLayout._generateLayoutParams17307 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._generateLayoutParams17308 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._generateDefaultLayoutParams17309 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._isBaselineAligned17310 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "isBaselineAligned", "()Z");
			global::android.widget.LinearLayout._setBaselineAligned17311 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setBaselineAligned", "(Z)V");
			global::android.widget.LinearLayout._getBaselineAlignedChildIndex17312 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getBaselineAlignedChildIndex", "()I");
			global::android.widget.LinearLayout._setBaselineAlignedChildIndex17313 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setBaselineAlignedChildIndex", "(I)V");
			global::android.widget.LinearLayout._getWeightSum17314 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getWeightSum", "()F");
			global::android.widget.LinearLayout._setWeightSum17315 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setWeightSum", "(F)V");
			global::android.widget.LinearLayout._setOrientation17316 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setOrientation", "(I)V");
			global::android.widget.LinearLayout._getOrientation17317 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getOrientation", "()I");
			global::android.widget.LinearLayout._setHorizontalGravity17318 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setHorizontalGravity", "(I)V");
			global::android.widget.LinearLayout._setVerticalGravity17319 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setVerticalGravity", "(I)V");
			global::android.widget.LinearLayout._LinearLayout17320 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.LinearLayout._LinearLayout17321 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
