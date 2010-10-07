namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class EventLog : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static EventLog()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.EventLog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.EventLog(@__env);
			}
		}
		protected EventLog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Event : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Event()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.EventLog.Event), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.util.EventLog.Event(@__env);
				}
			}
			internal Event(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _getData8195;
			public global::java.lang.Object getData() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.util.EventLog.Event._getData8195));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getData8195));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getTag8196;
			public int getTag() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.util.EventLog.Event._getTag8196);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getTag8196);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getThreadId8197;
			public int getThreadId() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.util.EventLog.Event._getThreadId8197);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getThreadId8197);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getProcessId8198;
			public int getProcessId() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.util.EventLog.Event._getProcessId8198);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getProcessId8198);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getTimeNanos8199;
			public long getTimeNanos() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this, global::android.util.EventLog.Event._getTimeNanos8199);
				else
					return @__env.CallNonVirtualLongMethod(this, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getTimeNanos8199);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.util.EventLog.Event.staticClass = @__class;
				global::android.util.EventLog.Event._getData8195 = @__env.GetMethodID(global::android.util.EventLog.Event.staticClass, "getData", "()Ljava/lang/Object;");
				global::android.util.EventLog.Event._getTag8196 = @__env.GetMethodID(global::android.util.EventLog.Event.staticClass, "getTag", "()I");
				global::android.util.EventLog.Event._getThreadId8197 = @__env.GetMethodID(global::android.util.EventLog.Event.staticClass, "getThreadId", "()I");
				global::android.util.EventLog.Event._getProcessId8198 = @__env.GetMethodID(global::android.util.EventLog.Event.staticClass, "getProcessId", "()I");
				global::android.util.EventLog.Event._getTimeNanos8199 = @__env.GetMethodID(global::android.util.EventLog.Event.staticClass, "getTimeNanos", "()J");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTagName8200;
		public static global::java.lang.String getTagName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.EventLog.staticClass, global::android.util.EventLog._getTagName8200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeEvent8201;
		public static int writeEvent(int arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent8201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeEvent8202;
		public static int writeEvent(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent8202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeEvent8203;
		public static int writeEvent(int arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent8203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeEvent8204;
		public static int writeEvent(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent8204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readEvents8205;
		public static void readEvents(int[] arg0, java.util.Collection arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.EventLog.staticClass, global::android.util.EventLog._readEvents8205, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTagCode8206;
		public static int getTagCode(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._getTagCode8206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _EventLog8207;
		public EventLog()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.EventLog.staticClass, global::android.util.EventLog._EventLog8207, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.EventLog.staticClass = @__class;
			global::android.util.EventLog._getTagName8200 = @__env.GetStaticMethodID(global::android.util.EventLog.staticClass, "getTagName", "(I)Ljava/lang/String;");
			global::android.util.EventLog._writeEvent8201 = @__env.GetStaticMethodID(global::android.util.EventLog.staticClass, "writeEvent", "(IJ)I");
			global::android.util.EventLog._writeEvent8202 = @__env.GetStaticMethodID(global::android.util.EventLog.staticClass, "writeEvent", "(ILjava/lang/String;)I");
			global::android.util.EventLog._writeEvent8203 = @__env.GetStaticMethodID(global::android.util.EventLog.staticClass, "writeEvent", "(I[Ljava/lang/Object;)I");
			global::android.util.EventLog._writeEvent8204 = @__env.GetStaticMethodID(global::android.util.EventLog.staticClass, "writeEvent", "(II)I");
			global::android.util.EventLog._readEvents8205 = @__env.GetStaticMethodID(global::android.util.EventLog.staticClass, "readEvents", "([ILjava/util/Collection;)V");
			global::android.util.EventLog._getTagCode8206 = @__env.GetStaticMethodID(global::android.util.EventLog.staticClass, "getTagCode", "(Ljava/lang/String;)I");
			global::android.util.EventLog._EventLog8207 = @__env.GetMethodID(global::android.util.EventLog.staticClass, "<init>", "()V");
		}
	}
}
