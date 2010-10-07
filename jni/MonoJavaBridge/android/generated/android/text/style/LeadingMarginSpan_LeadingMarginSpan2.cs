namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface LeadingMarginSpan_LeadingMarginSpan2 : LeadingMarginSpan, WrapTogetherSpan
	{
		int getLeadingMarginLineCount();
	}

	public partial class LeadingMarginSpan_LeadingMarginSpan2_
	{
		public static global::java.lang.Class _class
		{
			get { return __LeadingMarginSpan_LeadingMarginSpan2.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __LeadingMarginSpan_LeadingMarginSpan2 : java.lang.Object, LeadingMarginSpan_LeadingMarginSpan2
	{
		internal static global::java.lang.Class staticClass;
		static __LeadingMarginSpan_LeadingMarginSpan2()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2(@__env);
			}
		}
		internal __LeadingMarginSpan_LeadingMarginSpan2(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeadingMarginLineCount7980;
		 int android.text.style.LeadingMarginSpan_LeadingMarginSpan2.getLeadingMarginLineCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2._getLeadingMarginLineCount7980);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2.staticClass, global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2._getLeadingMarginLineCount7980);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeadingMargin7981;
		 int android.text.style.LeadingMarginSpan.getLeadingMargin(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2._getLeadingMargin7981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2.staticClass, global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2._getLeadingMargin7981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawLeadingMargin7982;
		 void android.text.style.LeadingMarginSpan.drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2._drawLeadingMargin7982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2.staticClass, global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2._drawLeadingMargin7982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg11));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2.staticClass = @__class;
			global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2._getLeadingMarginLineCount7980 = @__env.GetMethodID(global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2.staticClass, "android.text.style.LeadingMarginSpan_LeadingMarginSpan2.getLeadingMarginLineCount", "()I");
			global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2._getLeadingMargin7981 = @__env.GetMethodID(global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2.staticClass, "android.text.style.LeadingMarginSpan.getLeadingMargin", "(Z)I");
			global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2._drawLeadingMargin7982 = @__env.GetMethodID(global::android.text.style.__LeadingMarginSpan_LeadingMarginSpan2.staticClass, "android.text.style.LeadingMarginSpan.drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
		}
	}
}
