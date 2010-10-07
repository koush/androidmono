namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface AttributeSet 
	{
		global::java.lang.String getAttributeValue(int arg0);
		global::java.lang.String getAttributeValue(java.lang.String arg0, java.lang.String arg1);
		int getAttributeCount();
		global::java.lang.String getAttributeName(int arg0);
		global::java.lang.String getPositionDescription();
		int getAttributeNameResource(int arg0);
		int getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3);
		int getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2);
		bool getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2);
		bool getAttributeBooleanValue(int arg0, bool arg1);
		int getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2);
		int getAttributeResourceValue(int arg0, int arg1);
		int getAttributeIntValue(int arg0, int arg1);
		int getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2);
		int getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2);
		int getAttributeUnsignedIntValue(int arg0, int arg1);
		float getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2);
		float getAttributeFloatValue(int arg0, float arg1);
		global::java.lang.String getIdAttribute();
		global::java.lang.String getClassAttribute();
		int getIdAttributeResourceValue(int arg0);
		int getStyleAttribute();
	}

	public partial class AttributeSet_
	{
		public static global::java.lang.Class _class
		{
			get { return __AttributeSet.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __AttributeSet : java.lang.Object, AttributeSet
	{
		internal static global::java.lang.Class staticClass;
		static __AttributeSet()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.__AttributeSet), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.__AttributeSet(@__env);
			}
		}
		internal __AttributeSet(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue8139;
		 global::java.lang.String android.util.AttributeSet.getAttributeValue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.__AttributeSet._getAttributeValue8139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeValue8139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue8140;
		 global::java.lang.String android.util.AttributeSet.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.__AttributeSet._getAttributeValue8140, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeValue8140, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeCount8141;
		 int android.util.AttributeSet.getAttributeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getAttributeCount8141);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeCount8141);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeName8142;
		 global::java.lang.String android.util.AttributeSet.getAttributeName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.__AttributeSet._getAttributeName8142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeName8142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPositionDescription8143;
		 global::java.lang.String android.util.AttributeSet.getPositionDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.__AttributeSet._getPositionDescription8143));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getPositionDescription8143));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeNameResource8144;
		 int android.util.AttributeSet.getAttributeNameResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getAttributeNameResource8144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeNameResource8144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeListValue8145;
		 int android.util.AttributeSet.getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getAttributeListValue8145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeListValue8145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeListValue8146;
		 int android.util.AttributeSet.getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getAttributeListValue8146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeListValue8146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeBooleanValue8147;
		 bool android.util.AttributeSet.getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.util.__AttributeSet._getAttributeBooleanValue8147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeBooleanValue8147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeBooleanValue8148;
		 bool android.util.AttributeSet.getAttributeBooleanValue(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.util.__AttributeSet._getAttributeBooleanValue8148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeBooleanValue8148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeResourceValue8149;
		 int android.util.AttributeSet.getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getAttributeResourceValue8149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeResourceValue8149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeResourceValue8150;
		 int android.util.AttributeSet.getAttributeResourceValue(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getAttributeResourceValue8150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeResourceValue8150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeIntValue8151;
		 int android.util.AttributeSet.getAttributeIntValue(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getAttributeIntValue8151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeIntValue8151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeIntValue8152;
		 int android.util.AttributeSet.getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getAttributeIntValue8152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeIntValue8152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeUnsignedIntValue8153;
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getAttributeUnsignedIntValue8153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeUnsignedIntValue8153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeUnsignedIntValue8154;
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getAttributeUnsignedIntValue8154, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeUnsignedIntValue8154, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeFloatValue8155;
		 float android.util.AttributeSet.getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.util.__AttributeSet._getAttributeFloatValue8155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeFloatValue8155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeFloatValue8156;
		 float android.util.AttributeSet.getAttributeFloatValue(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.util.__AttributeSet._getAttributeFloatValue8156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getAttributeFloatValue8156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIdAttribute8157;
		 global::java.lang.String android.util.AttributeSet.getIdAttribute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.__AttributeSet._getIdAttribute8157));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getIdAttribute8157));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getClassAttribute8158;
		 global::java.lang.String android.util.AttributeSet.getClassAttribute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.__AttributeSet._getClassAttribute8158));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getClassAttribute8158));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIdAttributeResourceValue8159;
		 int android.util.AttributeSet.getIdAttributeResourceValue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getIdAttributeResourceValue8159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getIdAttributeResourceValue8159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStyleAttribute8160;
		 int android.util.AttributeSet.getStyleAttribute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.__AttributeSet._getStyleAttribute8160);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.__AttributeSet.staticClass, global::android.util.__AttributeSet._getStyleAttribute8160);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.__AttributeSet.staticClass = @__class;
			global::android.util.__AttributeSet._getAttributeValue8139 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeValue", "(I)Ljava/lang/String;");
			global::android.util.__AttributeSet._getAttributeValue8140 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.util.__AttributeSet._getAttributeCount8141 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeCount", "()I");
			global::android.util.__AttributeSet._getAttributeName8142 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeName", "(I)Ljava/lang/String;");
			global::android.util.__AttributeSet._getPositionDescription8143 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getPositionDescription", "()Ljava/lang/String;");
			global::android.util.__AttributeSet._getAttributeNameResource8144 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeNameResource", "(I)I");
			global::android.util.__AttributeSet._getAttributeListValue8145 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I");
			global::android.util.__AttributeSet._getAttributeListValue8146 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeListValue", "(I[Ljava/lang/String;I)I");
			global::android.util.__AttributeSet._getAttributeBooleanValue8147 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			global::android.util.__AttributeSet._getAttributeBooleanValue8148 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeBooleanValue", "(IZ)Z");
			global::android.util.__AttributeSet._getAttributeResourceValue8149 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.util.__AttributeSet._getAttributeResourceValue8150 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeResourceValue", "(II)I");
			global::android.util.__AttributeSet._getAttributeIntValue8151 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeIntValue", "(II)I");
			global::android.util.__AttributeSet._getAttributeIntValue8152 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.util.__AttributeSet._getAttributeUnsignedIntValue8153 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.util.__AttributeSet._getAttributeUnsignedIntValue8154 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeUnsignedIntValue", "(II)I");
			global::android.util.__AttributeSet._getAttributeFloatValue8155 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F");
			global::android.util.__AttributeSet._getAttributeFloatValue8156 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getAttributeFloatValue", "(IF)F");
			global::android.util.__AttributeSet._getIdAttribute8157 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getIdAttribute", "()Ljava/lang/String;");
			global::android.util.__AttributeSet._getClassAttribute8158 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getClassAttribute", "()Ljava/lang/String;");
			global::android.util.__AttributeSet._getIdAttributeResourceValue8159 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getIdAttributeResourceValue", "(I)I");
			global::android.util.__AttributeSet._getStyleAttribute8160 = @__env.GetMethodID(global::android.util.__AttributeSet.staticClass, "android.util.AttributeSet.getStyleAttribute", "()I");
		}
	}
}
