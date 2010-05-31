namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class LinearLayout : android.view.ViewGroup
	{
		internal new static global::java.lang.Class staticClass;
		static LinearLayout()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.LinearLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.LinearLayout(@__env);
			}
		}
		protected LinearLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public new class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{
			internal new static global::java.lang.Class staticClass;
			static LayoutParams()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.LinearLayout.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.LinearLayout.LayoutParams(@__env);
				}
			}
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _debug10397;
			public virtual global::java.lang.String debug(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.LinearLayout.LayoutParams._debug10397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._debug10397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10398;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams10398, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10399;
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams10399, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10400;
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams10400, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10401;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams10401, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10402;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams10402, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.FieldId _weight10403;
			public float weight
			{
				get
				{
					return default(float);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _gravity10404;
			public int gravity
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
				global::android.widget.LinearLayout.LayoutParams.staticClass = @__class;
				global::android.widget.LinearLayout.LayoutParams._debug10397 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams10398 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams10399 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams10400 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams10401 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams10402 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGravity10405;
		public virtual void setGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.LinearLayout._setGravity10405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setGravity10405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10406;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.LinearLayout._onLayout10406, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._onLayout10406, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline10407;
		public override int getBaseline() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.LinearLayout._getBaseline10407);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getBaseline10407);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10408;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.LinearLayout._onMeasure10408, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._onMeasure10408, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams10409;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.LinearLayout._checkLayoutParams10409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._checkLayoutParams10409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10410;
		public virtual new global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.LinearLayout._generateLayoutParams10410, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateLayoutParams10410, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10411;
		protected virtual new global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.LinearLayout._generateLayoutParams10411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateLayoutParams10411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams10412;
		protected virtual new global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.LinearLayout._generateDefaultLayoutParams10412));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateDefaultLayoutParams10412));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBaselineAligned10413;
		public virtual bool isBaselineAligned() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.LinearLayout._isBaselineAligned10413);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._isBaselineAligned10413);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBaselineAligned10414;
		public virtual void setBaselineAligned(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.LinearLayout._setBaselineAligned10414, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setBaselineAligned10414, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaselineAlignedChildIndex10415;
		public virtual int getBaselineAlignedChildIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.LinearLayout._getBaselineAlignedChildIndex10415);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getBaselineAlignedChildIndex10415);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBaselineAlignedChildIndex10416;
		public virtual void setBaselineAlignedChildIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.LinearLayout._setBaselineAlignedChildIndex10416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setBaselineAlignedChildIndex10416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWeightSum10417;
		public virtual float getWeightSum() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.LinearLayout._getWeightSum10417);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getWeightSum10417);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWeightSum10418;
		public virtual void setWeightSum(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.LinearLayout._setWeightSum10418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setWeightSum10418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOrientation10419;
		public virtual void setOrientation(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.LinearLayout._setOrientation10419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setOrientation10419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOrientation10420;
		public virtual int getOrientation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.LinearLayout._getOrientation10420);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getOrientation10420);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalGravity10421;
		public virtual void setHorizontalGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.LinearLayout._setHorizontalGravity10421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setHorizontalGravity10421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalGravity10422;
		public virtual void setVerticalGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.LinearLayout._setVerticalGravity10422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setVerticalGravity10422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LinearLayout10423;
		public LinearLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._LinearLayout10423, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LinearLayout10424;
		public LinearLayout(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._LinearLayout10424, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.LinearLayout.staticClass = @__class;
			global::android.widget.LinearLayout._setGravity10405 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setGravity", "(I)V");
			global::android.widget.LinearLayout._onLayout10406 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.LinearLayout._getBaseline10407 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "getBaseline", "()I");
			global::android.widget.LinearLayout._onMeasure10408 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.LinearLayout._checkLayoutParams10409 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.LinearLayout._generateLayoutParams10410 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._generateLayoutParams10411 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._generateDefaultLayoutParams10412 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._isBaselineAligned10413 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "isBaselineAligned", "()Z");
			global::android.widget.LinearLayout._setBaselineAligned10414 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setBaselineAligned", "(Z)V");
			global::android.widget.LinearLayout._getBaselineAlignedChildIndex10415 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "getBaselineAlignedChildIndex", "()I");
			global::android.widget.LinearLayout._setBaselineAlignedChildIndex10416 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setBaselineAlignedChildIndex", "(I)V");
			global::android.widget.LinearLayout._getWeightSum10417 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "getWeightSum", "()F");
			global::android.widget.LinearLayout._setWeightSum10418 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setWeightSum", "(F)V");
			global::android.widget.LinearLayout._setOrientation10419 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setOrientation", "(I)V");
			global::android.widget.LinearLayout._getOrientation10420 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "getOrientation", "()I");
			global::android.widget.LinearLayout._setHorizontalGravity10421 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setHorizontalGravity", "(I)V");
			global::android.widget.LinearLayout._setVerticalGravity10422 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setVerticalGravity", "(I)V");
			global::android.widget.LinearLayout._LinearLayout10423 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.LinearLayout._LinearLayout10424 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
