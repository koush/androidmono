namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinearLayout : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinearLayout()
		{
			InitJNI();
		}
		protected LinearLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutParams()
			{
				InitJNI();
			}
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _debug17190;
			public virtual global::java.lang.String debug(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.LinearLayout.LayoutParams._debug17190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._debug17190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17191;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams17191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17192;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams17192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17193;
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams17193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17194;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams17194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17195;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams17195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _weight17196;
			public float weight
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _weight17196);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _gravity17197;
			public int gravity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _gravity17197);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.LinearLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/LinearLayout$LayoutParams"));
				global::android.widget.LinearLayout.LayoutParams._debug17190 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams17191 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams17192 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams17193 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams17194 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams17195 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::android.widget.LinearLayout.LayoutParams._weight17196 = @__env.GetFieldIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "weight", "F");
				global::android.widget.LinearLayout.LayoutParams._gravity17197 = @__env.GetFieldIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "gravity", "I");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGravity17198;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setGravity17198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setGravity17198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17199;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._onLayout17199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._onLayout17199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline17200;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.LinearLayout._getBaseline17200);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getBaseline17200);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17201;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._onMeasure17201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._onMeasure17201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17202;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.LinearLayout._checkLayoutParams17202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._checkLayoutParams17202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17203;
		public virtual global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.LinearLayout._generateLayoutParams17203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateLayoutParams17203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17204;
		protected virtual global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.LinearLayout._generateLayoutParams17204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateLayoutParams17204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17205;
		protected virtual global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.LinearLayout._generateDefaultLayoutParams17205)) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateDefaultLayoutParams17205)) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _isBaselineAligned17206;
		public virtual bool isBaselineAligned() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.LinearLayout._isBaselineAligned17206);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._isBaselineAligned17206);
		}
		internal static global::MonoJavaBridge.MethodId _setBaselineAligned17207;
		public virtual void setBaselineAligned(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setBaselineAligned17207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setBaselineAligned17207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBaselineAlignedChildIndex17208;
		public virtual int getBaselineAlignedChildIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.LinearLayout._getBaselineAlignedChildIndex17208);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getBaselineAlignedChildIndex17208);
		}
		internal static global::MonoJavaBridge.MethodId _setBaselineAlignedChildIndex17209;
		public virtual void setBaselineAlignedChildIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setBaselineAlignedChildIndex17209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setBaselineAlignedChildIndex17209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getWeightSum17210;
		public virtual float getWeightSum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.LinearLayout._getWeightSum17210);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getWeightSum17210);
		}
		internal static global::MonoJavaBridge.MethodId _setWeightSum17211;
		public virtual void setWeightSum(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setWeightSum17211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setWeightSum17211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOrientation17212;
		public virtual void setOrientation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setOrientation17212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setOrientation17212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOrientation17213;
		public virtual int getOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.LinearLayout._getOrientation17213);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getOrientation17213);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalGravity17214;
		public virtual void setHorizontalGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setHorizontalGravity17214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setHorizontalGravity17214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalGravity17215;
		public virtual void setVerticalGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setVerticalGravity17215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setVerticalGravity17215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LinearLayout17216;
		public LinearLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._LinearLayout17216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinearLayout17217;
		public LinearLayout(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._LinearLayout17217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.LinearLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/LinearLayout"));
			global::android.widget.LinearLayout._setGravity17198 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setGravity", "(I)V");
			global::android.widget.LinearLayout._onLayout17199 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.LinearLayout._getBaseline17200 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getBaseline", "()I");
			global::android.widget.LinearLayout._onMeasure17201 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.LinearLayout._checkLayoutParams17202 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.LinearLayout._generateLayoutParams17203 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._generateLayoutParams17204 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._generateDefaultLayoutParams17205 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._isBaselineAligned17206 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "isBaselineAligned", "()Z");
			global::android.widget.LinearLayout._setBaselineAligned17207 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setBaselineAligned", "(Z)V");
			global::android.widget.LinearLayout._getBaselineAlignedChildIndex17208 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getBaselineAlignedChildIndex", "()I");
			global::android.widget.LinearLayout._setBaselineAlignedChildIndex17209 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setBaselineAlignedChildIndex", "(I)V");
			global::android.widget.LinearLayout._getWeightSum17210 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getWeightSum", "()F");
			global::android.widget.LinearLayout._setWeightSum17211 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setWeightSum", "(F)V");
			global::android.widget.LinearLayout._setOrientation17212 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setOrientation", "(I)V");
			global::android.widget.LinearLayout._getOrientation17213 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getOrientation", "()I");
			global::android.widget.LinearLayout._setHorizontalGravity17214 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setHorizontalGravity", "(I)V");
			global::android.widget.LinearLayout._setVerticalGravity17215 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setVerticalGravity", "(I)V");
			global::android.widget.LinearLayout._LinearLayout17216 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.LinearLayout._LinearLayout17217 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
