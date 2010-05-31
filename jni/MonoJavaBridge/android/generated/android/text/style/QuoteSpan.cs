namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class QuoteSpan : java.lang.Object, LeadingMarginSpan, ParcelableSpan
	{
		internal static global::java.lang.Class staticClass;
		static QuoteSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.QuoteSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.QuoteSpan(@__env);
			}
		}
		protected QuoteSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7374;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.QuoteSpan._writeToParcel7374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._writeToParcel7374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7375;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.QuoteSpan._describeContents7375);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._describeContents7375);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColor7376;
		public virtual int getColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.QuoteSpan._getColor7376);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._getColor7376);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7377;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.QuoteSpan._getSpanTypeId7377);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._getSpanTypeId7377);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeadingMargin7378;
		public virtual int getLeadingMargin(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.QuoteSpan._getLeadingMargin7378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._getLeadingMargin7378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawLeadingMargin7379;
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.QuoteSpan._drawLeadingMargin7379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._drawLeadingMargin7379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11));
		}
		internal static global::net.sf.jni4net.jni.MethodId _QuoteSpan7380;
		public QuoteSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._QuoteSpan7380, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _QuoteSpan7381;
		public QuoteSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._QuoteSpan7381, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _QuoteSpan7382;
		public QuoteSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._QuoteSpan7382, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.QuoteSpan.staticClass = @__class;
			global::android.text.style.QuoteSpan._writeToParcel7374 = @__env.GetMethodID(global::android.text.style.QuoteSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.QuoteSpan._describeContents7375 = @__env.GetMethodID(global::android.text.style.QuoteSpan.staticClass, "describeContents", "()I");
			global::android.text.style.QuoteSpan._getColor7376 = @__env.GetMethodID(global::android.text.style.QuoteSpan.staticClass, "getColor", "()I");
			global::android.text.style.QuoteSpan._getSpanTypeId7377 = @__env.GetMethodID(global::android.text.style.QuoteSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.QuoteSpan._getLeadingMargin7378 = @__env.GetMethodID(global::android.text.style.QuoteSpan.staticClass, "getLeadingMargin", "(Z)I");
			global::android.text.style.QuoteSpan._drawLeadingMargin7379 = @__env.GetMethodID(global::android.text.style.QuoteSpan.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
			global::android.text.style.QuoteSpan._QuoteSpan7380 = @__env.GetMethodID(global::android.text.style.QuoteSpan.staticClass, "<init>", "()V");
			global::android.text.style.QuoteSpan._QuoteSpan7381 = @__env.GetMethodID(global::android.text.style.QuoteSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.QuoteSpan._QuoteSpan7382 = @__env.GetMethodID(global::android.text.style.QuoteSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
	public static class QuoteSpanExtensionMethods
	{
		public static void drawLeadingMargin(this global::android.text.style.QuoteSpan __this, android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, string arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			__this.drawLeadingMargin(arg0, arg1, arg2, arg3, arg4, arg5, arg6, (global::java.lang.String)arg7, arg8, arg9, arg10, arg11);
		}
	}
}
