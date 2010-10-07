namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpConnectionMetrics 
	{
		void reset();
		long getRequestCount();
		long getResponseCount();
		long getSentBytesCount();
		long getReceivedBytesCount();
		global::java.lang.Object getMetric(java.lang.String arg0);
	}

	public partial class HttpConnectionMetrics_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpConnectionMetrics.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpConnectionMetrics : java.lang.Object, HttpConnectionMetrics
	{
		internal static global::java.lang.Class staticClass;
		static __HttpConnectionMetrics()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HttpConnectionMetrics), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HttpConnectionMetrics(@__env);
			}
		}
		internal __HttpConnectionMetrics(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset14225;
		 void org.apache.http.HttpConnectionMetrics.reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpConnectionMetrics._reset14225);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpConnectionMetrics.staticClass, global::org.apache.http.__HttpConnectionMetrics._reset14225);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRequestCount14226;
		 long org.apache.http.HttpConnectionMetrics.getRequestCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::org.apache.http.__HttpConnectionMetrics._getRequestCount14226);
			else
				return @__env.CallNonVirtualLongMethod(this, global::org.apache.http.__HttpConnectionMetrics.staticClass, global::org.apache.http.__HttpConnectionMetrics._getRequestCount14226);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResponseCount14227;
		 long org.apache.http.HttpConnectionMetrics.getResponseCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::org.apache.http.__HttpConnectionMetrics._getResponseCount14227);
			else
				return @__env.CallNonVirtualLongMethod(this, global::org.apache.http.__HttpConnectionMetrics.staticClass, global::org.apache.http.__HttpConnectionMetrics._getResponseCount14227);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSentBytesCount14228;
		 long org.apache.http.HttpConnectionMetrics.getSentBytesCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::org.apache.http.__HttpConnectionMetrics._getSentBytesCount14228);
			else
				return @__env.CallNonVirtualLongMethod(this, global::org.apache.http.__HttpConnectionMetrics.staticClass, global::org.apache.http.__HttpConnectionMetrics._getSentBytesCount14228);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getReceivedBytesCount14229;
		 long org.apache.http.HttpConnectionMetrics.getReceivedBytesCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::org.apache.http.__HttpConnectionMetrics._getReceivedBytesCount14229);
			else
				return @__env.CallNonVirtualLongMethod(this, global::org.apache.http.__HttpConnectionMetrics.staticClass, global::org.apache.http.__HttpConnectionMetrics._getReceivedBytesCount14229);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetric14230;
		 global::java.lang.Object org.apache.http.HttpConnectionMetrics.getMetric(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpConnectionMetrics._getMetric14230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpConnectionMetrics.staticClass, global::org.apache.http.__HttpConnectionMetrics._getMetric14230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HttpConnectionMetrics.staticClass = @__class;
			global::org.apache.http.__HttpConnectionMetrics._reset14225 = @__env.GetMethodID(global::org.apache.http.__HttpConnectionMetrics.staticClass, "org.apache.http.HttpConnectionMetrics.reset", "()V");
			global::org.apache.http.__HttpConnectionMetrics._getRequestCount14226 = @__env.GetMethodID(global::org.apache.http.__HttpConnectionMetrics.staticClass, "org.apache.http.HttpConnectionMetrics.getRequestCount", "()J");
			global::org.apache.http.__HttpConnectionMetrics._getResponseCount14227 = @__env.GetMethodID(global::org.apache.http.__HttpConnectionMetrics.staticClass, "org.apache.http.HttpConnectionMetrics.getResponseCount", "()J");
			global::org.apache.http.__HttpConnectionMetrics._getSentBytesCount14228 = @__env.GetMethodID(global::org.apache.http.__HttpConnectionMetrics.staticClass, "org.apache.http.HttpConnectionMetrics.getSentBytesCount", "()J");
			global::org.apache.http.__HttpConnectionMetrics._getReceivedBytesCount14229 = @__env.GetMethodID(global::org.apache.http.__HttpConnectionMetrics.staticClass, "org.apache.http.HttpConnectionMetrics.getReceivedBytesCount", "()J");
			global::org.apache.http.__HttpConnectionMetrics._getMetric14230 = @__env.GetMethodID(global::org.apache.http.__HttpConnectionMetrics.staticClass, "org.apache.http.HttpConnectionMetrics.getMetric", "(Ljava/lang/String;)Ljava/lang/Object;");
		}
	}
}
