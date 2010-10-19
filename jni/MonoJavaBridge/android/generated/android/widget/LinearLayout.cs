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
			internal static global::MonoJavaBridge.MethodId _debug12030;
			public virtual global::java.lang.String debug(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.LinearLayout.LayoutParams._debug12030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._debug12030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12031;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams12031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12032;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams12032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12033;
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams12033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12034;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams12034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12035;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, global::android.widget.LinearLayout.LayoutParams._LayoutParams12035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _weight12036;
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
			internal static global::MonoJavaBridge.FieldId _gravity12037;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.LinearLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/LinearLayout$LayoutParams"));
				global::android.widget.LinearLayout.LayoutParams._debug12030 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams12031 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams12032 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams12033 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams12034 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.LinearLayout.LayoutParams._LayoutParams12035 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGravity12038;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setGravity12038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setGravity12038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout12039;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._onLayout12039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._onLayout12039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline12040;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.LinearLayout._getBaseline12040);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getBaseline12040);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12041;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._onMeasure12041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._onMeasure12041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams12042;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.LinearLayout._checkLayoutParams12042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._checkLayoutParams12042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams12043;
		public virtual global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.LinearLayout._generateLayoutParams12043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateLayoutParams12043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams12044;
		protected virtual global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.LinearLayout._generateLayoutParams12044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateLayoutParams12044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams12045;
		protected virtual global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.LinearLayout._generateDefaultLayoutParams12045)) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._generateDefaultLayoutParams12045)) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _isBaselineAligned12046;
		public virtual bool isBaselineAligned() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.LinearLayout._isBaselineAligned12046);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._isBaselineAligned12046);
		}
		internal static global::MonoJavaBridge.MethodId _setBaselineAligned12047;
		public virtual void setBaselineAligned(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setBaselineAligned12047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setBaselineAligned12047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getBaselineAlignedChildIndex12048;
		public virtual int getBaselineAlignedChildIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.LinearLayout._getBaselineAlignedChildIndex12048);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getBaselineAlignedChildIndex12048);
		}
		internal static global::MonoJavaBridge.MethodId _setBaselineAlignedChildIndex12049;
		public virtual void setBaselineAlignedChildIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setBaselineAlignedChildIndex12049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setBaselineAlignedChildIndex12049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getWeightSum12050;
		public virtual float getWeightSum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.LinearLayout._getWeightSum12050);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getWeightSum12050);
		}
		internal static global::MonoJavaBridge.MethodId _setWeightSum12051;
		public virtual void setWeightSum(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setWeightSum12051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setWeightSum12051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOrientation12052;
		public virtual void setOrientation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setOrientation12052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setOrientation12052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOrientation12053;
		public virtual int getOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.LinearLayout._getOrientation12053);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._getOrientation12053);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalGravity12054;
		public virtual void setHorizontalGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setHorizontalGravity12054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setHorizontalGravity12054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalGravity12055;
		public virtual void setVerticalGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.LinearLayout._setVerticalGravity12055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._setVerticalGravity12055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LinearLayout12056;
		public LinearLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._LinearLayout12056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinearLayout12057;
		public LinearLayout(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.LinearLayout.staticClass, global::android.widget.LinearLayout._LinearLayout12057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.widget.LinearLayout._setGravity12038 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setGravity", "(I)V");
			global::android.widget.LinearLayout._onLayout12039 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.LinearLayout._getBaseline12040 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getBaseline", "()I");
			global::android.widget.LinearLayout._onMeasure12041 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.LinearLayout._checkLayoutParams12042 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.LinearLayout._generateLayoutParams12043 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._generateLayoutParams12044 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._generateDefaultLayoutParams12045 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.LinearLayout._isBaselineAligned12046 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "isBaselineAligned", "()Z");
			global::android.widget.LinearLayout._setBaselineAligned12047 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setBaselineAligned", "(Z)V");
			global::android.widget.LinearLayout._getBaselineAlignedChildIndex12048 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getBaselineAlignedChildIndex", "()I");
			global::android.widget.LinearLayout._setBaselineAlignedChildIndex12049 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setBaselineAlignedChildIndex", "(I)V");
			global::android.widget.LinearLayout._getWeightSum12050 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getWeightSum", "()F");
			global::android.widget.LinearLayout._setWeightSum12051 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setWeightSum", "(F)V");
			global::android.widget.LinearLayout._setOrientation12052 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setOrientation", "(I)V");
			global::android.widget.LinearLayout._getOrientation12053 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "getOrientation", "()I");
			global::android.widget.LinearLayout._setHorizontalGravity12054 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setHorizontalGravity", "(I)V");
			global::android.widget.LinearLayout._setVerticalGravity12055 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "setVerticalGravity", "(I)V");
			global::android.widget.LinearLayout._LinearLayout12056 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.LinearLayout._LinearLayout12057 = @__env.GetMethodIDNoThrow(global::android.widget.LinearLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
