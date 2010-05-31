namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BoringLayout : android.text.Layout, android.text.TextUtils.EllipsizeCallback
	{
		internal new static global::java.lang.Class staticClass;
		static BoringLayout()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.BoringLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.BoringLayout(@__env);
			}
		}
		protected BoringLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Metrics : android.graphics.Paint.FontMetricsInt
		{
			internal new static global::java.lang.Class staticClass;
			static Metrics()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.BoringLayout.Metrics), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.text.BoringLayout.Metrics(@__env);
				}
			}
			protected Metrics(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString6700;
			public override global::java.lang.String toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.BoringLayout.Metrics._toString6700));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.BoringLayout.Metrics.staticClass, global::android.text.BoringLayout.Metrics._toString6700));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Metrics6701;
			public Metrics()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.text.BoringLayout.Metrics.staticClass, global::android.text.BoringLayout.Metrics._Metrics6701, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _width6702;
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.text.BoringLayout.Metrics.staticClass = @__class;
				global::android.text.BoringLayout.Metrics._toString6700 = @__env.GetMethodID(global::android.text.BoringLayout.Metrics.staticClass, "toString", "()Ljava/lang/String;");
				global::android.text.BoringLayout.Metrics._Metrics6701 = @__env.GetMethodID(global::android.text.BoringLayout.Metrics.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _make6703;
		public static global::android.text.BoringLayout make(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallStaticObjectMethodPtr(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._make6703, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _make6704;
		public static global::android.text.BoringLayout make(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallStaticObjectMethodPtr(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._make6704, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw6705;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.BoringLayout._draw6705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._draw6705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight6706;
		public override int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getHeight6706);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getHeight6706);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount6707;
		public override int getLineCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getLineCount6707);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineCount6707);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsizedWidth6708;
		public override int getEllipsizedWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getEllipsizedWidth6708);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getEllipsizedWidth6708);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineTop6709;
		public override int getLineTop(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getLineTop6709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineTop6709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineDescent6710;
		public override int getLineDescent(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getLineDescent6710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineDescent6710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineStart6711;
		public override int getLineStart(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getLineStart6711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineStart6711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphDirection6712;
		public override int getParagraphDirection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getParagraphDirection6712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getParagraphDirection6712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineContainsTab6713;
		public override bool getLineContainsTab(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.BoringLayout._getLineContainsTab6713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineContainsTab6713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineDirections6714;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.BoringLayout._getLineDirections6714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineDirections6714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTopPadding6715;
		public override int getTopPadding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getTopPadding6715);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getTopPadding6715);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPadding6716;
		public override int getBottomPadding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getBottomPadding6716);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getBottomPadding6716);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineMax6717;
		public override float getLineMax(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.BoringLayout._getLineMax6717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getLineMax6717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisStart6718;
		public override int getEllipsisStart(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getEllipsisStart6718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getEllipsisStart6718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisCount6719;
		public override int getEllipsisCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.BoringLayout._getEllipsisCount6719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._getEllipsisCount6719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceOrMake6720;
		public virtual global::android.text.BoringLayout replaceOrMake(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.BoringLayout._replaceOrMake6720, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._replaceOrMake6720, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)));
		}
		public android.text.BoringLayout replaceOrMake(string arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7)
		{
			return replaceOrMake((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceOrMake6721;
		public virtual global::android.text.BoringLayout replaceOrMake(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.BoringLayout._replaceOrMake6721, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._replaceOrMake6721, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9)));
		}
		public android.text.BoringLayout replaceOrMake(string arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)
		{
			return replaceOrMake((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBoring6722;
		public static global::android.text.BoringLayout.Metrics isBoring(java.lang.CharSequence arg0, android.text.TextPaint arg1, android.text.BoringLayout.Metrics arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout.Metrics>(@__env, @__env.CallStaticObjectMethodPtr(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._isBoring6722, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBoring6723;
		public static global::android.text.BoringLayout.Metrics isBoring(java.lang.CharSequence arg0, android.text.TextPaint arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout.Metrics>(@__env, @__env.CallStaticObjectMethodPtr(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._isBoring6723, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ellipsized6724;
		public virtual void ellipsized(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.BoringLayout._ellipsized6724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.BoringLayout.staticClass, global::android.text.BoringLayout._ellipsized6724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BoringLayout6725;
		public BoringLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._BoringLayout6725, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BoringLayout6726;
		public BoringLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._BoringLayout6726, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.BoringLayout.staticClass = @__class;
			global::android.text.BoringLayout._make6703 = @__env.GetStaticMethodID(global::android.text.BoringLayout.staticClass, "make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landroid/text/BoringLayout;");
			global::android.text.BoringLayout._make6704 = @__env.GetStaticMethodID(global::android.text.BoringLayout.staticClass, "make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;");
			global::android.text.BoringLayout._draw6705 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V");
			global::android.text.BoringLayout._getHeight6706 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getHeight", "()I");
			global::android.text.BoringLayout._getLineCount6707 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineCount", "()I");
			global::android.text.BoringLayout._getEllipsizedWidth6708 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.BoringLayout._getLineTop6709 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineTop", "(I)I");
			global::android.text.BoringLayout._getLineDescent6710 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineDescent", "(I)I");
			global::android.text.BoringLayout._getLineStart6711 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineStart", "(I)I");
			global::android.text.BoringLayout._getParagraphDirection6712 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.BoringLayout._getLineContainsTab6713 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.BoringLayout._getLineDirections6714 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.BoringLayout._getTopPadding6715 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getTopPadding", "()I");
			global::android.text.BoringLayout._getBottomPadding6716 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getBottomPadding", "()I");
			global::android.text.BoringLayout._getLineMax6717 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineMax", "(I)F");
			global::android.text.BoringLayout._getEllipsisStart6718 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.BoringLayout._getEllipsisCount6719 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.BoringLayout._replaceOrMake6720 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;");
			global::android.text.BoringLayout._replaceOrMake6721 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landroid/text/BoringLayout;");
			global::android.text.BoringLayout._isBoring6722 = @__env.GetStaticMethodID(global::android.text.BoringLayout.staticClass, "isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;Landroid/text/BoringLayout$Metrics;)Landroid/text/BoringLayout$Metrics;");
			global::android.text.BoringLayout._isBoring6723 = @__env.GetStaticMethodID(global::android.text.BoringLayout.staticClass, "isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)Landroid/text/BoringLayout$Metrics;");
			global::android.text.BoringLayout._ellipsized6724 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "ellipsized", "(II)V");
			global::android.text.BoringLayout._BoringLayout6725 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)V");
			global::android.text.BoringLayout._BoringLayout6726 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)V");
		}
	}
}
