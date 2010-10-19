namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BoringLayout : android.text.Layout, android.text.TextUtils.EllipsizeCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BoringLayout()
		{
			InitJNI();
		}
		protected BoringLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Metrics : android.graphics.Paint.FontMetricsInt
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Metrics()
			{
				InitJNI();
			}
			protected Metrics(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString8152;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.BoringLayout.Metrics._toString8152)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.BoringLayout.Metrics.staticClass, global::android.text.BoringLayout.Metrics._toString8152)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _Metrics8153;
			public Metrics()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.BoringLayout.Metrics.staticClass, global::android.text.BoringLayout.Metrics._Metrics8153);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _width8154;
			public int width
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
				global::android.text.BoringLayout.Metrics.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/BoringLayout$Metrics"));
				global::android.text.BoringLayout.Metrics._toString8152 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.Metrics.staticClass, "toString", "()Ljava/lang/String;");
				global::android.text.BoringLayout.Metrics._Metrics8153 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.Metrics.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _make8155;
		public static global::android.text.BoringLayout make(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._make8155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.text.BoringLayout;
		}
		internal static global::MonoJavaBridge.MethodId _make8156;
		public static global::android.text.BoringLayout make(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._make8156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.text.BoringLayout;
		}
		internal static global::MonoJavaBridge.MethodId _draw8157;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.BoringLayout._draw8157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._draw8157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight8158;
		public override int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getHeight8158);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getHeight8158);
		}
		public new int LineCount
		{
			get
			{
				return getLineCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount8159;
		public override int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getLineCount8159);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineCount8159);
		}
		public new int EllipsizedWidth
		{
			get
			{
				return getEllipsizedWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsizedWidth8160;
		public override int getEllipsizedWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getEllipsizedWidth8160);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getEllipsizedWidth8160);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop8161;
		public override int getLineTop(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getLineTop8161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineTop8161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDescent8162;
		public override int getLineDescent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getLineDescent8162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineDescent8162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineStart8163;
		public override int getLineStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getLineStart8163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineStart8163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection8164;
		public override int getParagraphDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getParagraphDirection8164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getParagraphDirection8164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab8165;
		public override bool getLineContainsTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.BoringLayout._getLineContainsTab8165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineContainsTab8165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDirections8166;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.BoringLayout._getLineDirections8166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineDirections8166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
		}
		public new int TopPadding
		{
			get
			{
				return getTopPadding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPadding8167;
		public override int getTopPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getTopPadding8167);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getTopPadding8167);
		}
		public new int BottomPadding
		{
			get
			{
				return getBottomPadding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPadding8168;
		public override int getBottomPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getBottomPadding8168);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getBottomPadding8168);
		}
		internal static global::MonoJavaBridge.MethodId _getLineMax8169;
		public override float getLineMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.BoringLayout._getLineMax8169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineMax8169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart8170;
		public override int getEllipsisStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getEllipsisStart8170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getEllipsisStart8170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount8171;
		public override int getEllipsisCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.BoringLayout._getEllipsisCount8171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getEllipsisCount8171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _replaceOrMake8172;
		public virtual global::android.text.BoringLayout replaceOrMake(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.BoringLayout._replaceOrMake8172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.text.BoringLayout;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._replaceOrMake8172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.text.BoringLayout;
		}
		public android.text.BoringLayout replaceOrMake(string arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7)
		{
			return replaceOrMake((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}
		internal static global::MonoJavaBridge.MethodId _replaceOrMake8173;
		public virtual global::android.text.BoringLayout replaceOrMake(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.BoringLayout._replaceOrMake8173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.text.BoringLayout;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._replaceOrMake8173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.text.BoringLayout;
		}
		public android.text.BoringLayout replaceOrMake(string arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)
		{
			return replaceOrMake((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		}
		internal static global::MonoJavaBridge.MethodId _isBoring8174;
		public static global::android.text.BoringLayout.Metrics isBoring(java.lang.CharSequence arg0, android.text.TextPaint arg1, android.text.BoringLayout.Metrics arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._isBoring8174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.BoringLayout.Metrics;
		}
		internal static global::MonoJavaBridge.MethodId _isBoring8175;
		public static global::android.text.BoringLayout.Metrics isBoring(java.lang.CharSequence arg0, android.text.TextPaint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._isBoring8175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.BoringLayout.Metrics;
		}
		internal static global::MonoJavaBridge.MethodId _ellipsized8176;
		public virtual void ellipsized(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.BoringLayout._ellipsized8176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._ellipsized8176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BoringLayout8177;
		public BoringLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._BoringLayout8177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BoringLayout8178;
		public BoringLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._BoringLayout8178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.BoringLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/BoringLayout"));
			global::android.text.BoringLayout._make8155 = @__env.GetStaticMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landroid/text/BoringLayout;");
			global::android.text.BoringLayout._make8156 = @__env.GetStaticMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;");
			global::android.text.BoringLayout._draw8157 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V");
			global::android.text.BoringLayout._getHeight8158 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getHeight", "()I");
			global::android.text.BoringLayout._getLineCount8159 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getLineCount", "()I");
			global::android.text.BoringLayout._getEllipsizedWidth8160 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.BoringLayout._getLineTop8161 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getLineTop", "(I)I");
			global::android.text.BoringLayout._getLineDescent8162 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getLineDescent", "(I)I");
			global::android.text.BoringLayout._getLineStart8163 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getLineStart", "(I)I");
			global::android.text.BoringLayout._getParagraphDirection8164 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.BoringLayout._getLineContainsTab8165 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.BoringLayout._getLineDirections8166 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.BoringLayout._getTopPadding8167 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getTopPadding", "()I");
			global::android.text.BoringLayout._getBottomPadding8168 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getBottomPadding", "()I");
			global::android.text.BoringLayout._getLineMax8169 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getLineMax", "(I)F");
			global::android.text.BoringLayout._getEllipsisStart8170 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.BoringLayout._getEllipsisCount8171 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.BoringLayout._replaceOrMake8172 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;");
			global::android.text.BoringLayout._replaceOrMake8173 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landroid/text/BoringLayout;");
			global::android.text.BoringLayout._isBoring8174 = @__env.GetStaticMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;Landroid/text/BoringLayout$Metrics;)Landroid/text/BoringLayout$Metrics;");
			global::android.text.BoringLayout._isBoring8175 = @__env.GetStaticMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)Landroid/text/BoringLayout$Metrics;");
			global::android.text.BoringLayout._ellipsized8176 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "ellipsized", "(II)V");
			global::android.text.BoringLayout._BoringLayout8177 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)V");
			global::android.text.BoringLayout._BoringLayout8178 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)V");
		}
	}
}
