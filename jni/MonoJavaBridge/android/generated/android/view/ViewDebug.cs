namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ViewDebug : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ViewDebug()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.ViewDebug(@__env);
			}
		}
		protected ViewDebug(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface CapturedViewProperty : java.lang.annotation.Annotation
		{
			bool retrieveReturn();
		}

		public partial class CapturedViewProperty_
		{
			public static global::java.lang.Class _class
			{
				get { return __CapturedViewProperty.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __CapturedViewProperty : java.lang.Object, CapturedViewProperty
		{
			internal static global::java.lang.Class staticClass;
			static __CapturedViewProperty()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.__CapturedViewProperty), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.__CapturedViewProperty(@__env);
				}
			}
			internal __CapturedViewProperty(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _retrieveReturn9120;
			 bool android.view.ViewDebug.CapturedViewProperty.retrieveReturn() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__CapturedViewProperty._retrieveReturn9120);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__CapturedViewProperty.staticClass, global::android.view.ViewDebug.__CapturedViewProperty._retrieveReturn9120);
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals9121;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__CapturedViewProperty._equals9121, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__CapturedViewProperty.staticClass, global::android.view.ViewDebug.__CapturedViewProperty._equals9121, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString9122;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__CapturedViewProperty._toString9122));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__CapturedViewProperty.staticClass, global::android.view.ViewDebug.__CapturedViewProperty._toString9122));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hashCode9123;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__CapturedViewProperty._hashCode9123);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__CapturedViewProperty.staticClass, global::android.view.ViewDebug.__CapturedViewProperty._hashCode9123);
			}
			internal static global::net.sf.jni4net.jni.MethodId _annotationType9124;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__CapturedViewProperty._annotationType9124));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__CapturedViewProperty.staticClass, global::android.view.ViewDebug.__CapturedViewProperty._annotationType9124));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.__CapturedViewProperty.staticClass = @__class;
				global::android.view.ViewDebug.__CapturedViewProperty._retrieveReturn9120 = @__env.GetMethodID(global::android.view.ViewDebug.__CapturedViewProperty.staticClass, "android.view.ViewDebug.CapturedViewProperty.retrieveReturn", "()Z");
				global::android.view.ViewDebug.__CapturedViewProperty._equals9121 = @__env.GetMethodID(global::android.view.ViewDebug.__CapturedViewProperty.staticClass, "java.lang.annotation.Annotation.equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.__CapturedViewProperty._toString9122 = @__env.GetMethodID(global::android.view.ViewDebug.__CapturedViewProperty.staticClass, "java.lang.annotation.Annotation.toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__CapturedViewProperty._hashCode9123 = @__env.GetMethodID(global::android.view.ViewDebug.__CapturedViewProperty.staticClass, "java.lang.annotation.Annotation.hashCode", "()I");
				global::android.view.ViewDebug.__CapturedViewProperty._annotationType9124 = @__env.GetMethodID(global::android.view.ViewDebug.__CapturedViewProperty.staticClass, "java.lang.annotation.Annotation.annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface ExportedProperty : java.lang.annotation.Annotation
		{
			global::java.lang.String prefix();
			bool resolveId();
			global::android.view.ViewDebug.IntToString[] mapping();
			global::android.view.ViewDebug.IntToString[] indexMapping();
			global::android.view.ViewDebug.FlagToString[] flagMapping();
			bool deepExport();
		}

		public partial class ExportedProperty_
		{
			public static global::java.lang.Class _class
			{
				get { return __ExportedProperty.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __ExportedProperty : java.lang.Object, ExportedProperty
		{
			internal static global::java.lang.Class staticClass;
			static __ExportedProperty()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.__ExportedProperty), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.__ExportedProperty(@__env);
				}
			}
			internal __ExportedProperty(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _prefix9125;
			 global::java.lang.String android.view.ViewDebug.ExportedProperty.prefix() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._prefix9125));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._prefix9125));
			}
			internal static global::net.sf.jni4net.jni.MethodId _resolveId9126;
			 bool android.view.ViewDebug.ExportedProperty.resolveId() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty._resolveId9126);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._resolveId9126);
			}
			internal static global::net.sf.jni4net.jni.MethodId _mapping9127;
			 global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.mapping() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._mapping9127));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._mapping9127));
			}
			internal static global::net.sf.jni4net.jni.MethodId _indexMapping9128;
			 global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.indexMapping() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._indexMapping9128));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._indexMapping9128));
			}
			internal static global::net.sf.jni4net.jni.MethodId _flagMapping9129;
			 global::android.view.ViewDebug.FlagToString[] android.view.ViewDebug.ExportedProperty.flagMapping() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._flagMapping9129));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._flagMapping9129));
			}
			internal static global::net.sf.jni4net.jni.MethodId _deepExport9130;
			 bool android.view.ViewDebug.ExportedProperty.deepExport() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty._deepExport9130);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._deepExport9130);
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals9131;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty._equals9131, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._equals9131, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString9132;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._toString9132));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._toString9132));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hashCode9133;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__ExportedProperty._hashCode9133);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._hashCode9133);
			}
			internal static global::net.sf.jni4net.jni.MethodId _annotationType9134;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._annotationType9134));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._annotationType9134));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.__ExportedProperty.staticClass = @__class;
				global::android.view.ViewDebug.__ExportedProperty._prefix9125 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.prefix", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__ExportedProperty._resolveId9126 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.resolveId", "()Z");
				global::android.view.ViewDebug.__ExportedProperty._mapping9127 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.mapping", "()[Landroid/view/ViewDebug/IntToString;");
				global::android.view.ViewDebug.__ExportedProperty._indexMapping9128 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.indexMapping", "()[Landroid/view/ViewDebug/IntToString;");
				global::android.view.ViewDebug.__ExportedProperty._flagMapping9129 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.flagMapping", "()[Landroid/view/ViewDebug/FlagToString;");
				global::android.view.ViewDebug.__ExportedProperty._deepExport9130 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.deepExport", "()Z");
				global::android.view.ViewDebug.__ExportedProperty._equals9131 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "java.lang.annotation.Annotation.equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.__ExportedProperty._toString9132 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "java.lang.annotation.Annotation.toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__ExportedProperty._hashCode9133 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "java.lang.annotation.Annotation.hashCode", "()I");
				global::android.view.ViewDebug.__ExportedProperty._annotationType9134 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "java.lang.annotation.Annotation.annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface FlagToString : java.lang.annotation.Annotation
		{
			global::java.lang.String name();
			int equals();
			int mask();
			bool outputIf();
		}

		public partial class FlagToString_
		{
			public static global::java.lang.Class _class
			{
				get { return __FlagToString.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __FlagToString : java.lang.Object, FlagToString
		{
			internal static global::java.lang.Class staticClass;
			static __FlagToString()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.__FlagToString), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.__FlagToString(@__env);
				}
			}
			internal __FlagToString(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _name9135;
			 global::java.lang.String android.view.ViewDebug.FlagToString.name() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString._name9135));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._name9135));
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals9136;
			 int android.view.ViewDebug.FlagToString.equals() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__FlagToString._equals9136);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._equals9136);
			}
			internal static global::net.sf.jni4net.jni.MethodId _mask9137;
			 int android.view.ViewDebug.FlagToString.mask() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__FlagToString._mask9137);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._mask9137);
			}
			internal static global::net.sf.jni4net.jni.MethodId _outputIf9138;
			 bool android.view.ViewDebug.FlagToString.outputIf() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__FlagToString._outputIf9138);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._outputIf9138);
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals9139;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__FlagToString._equals9139, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._equals9139, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString9140;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString._toString9140));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._toString9140));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hashCode9141;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__FlagToString._hashCode9141);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._hashCode9141);
			}
			internal static global::net.sf.jni4net.jni.MethodId _annotationType9142;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString._annotationType9142));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._annotationType9142));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.__FlagToString.staticClass = @__class;
				global::android.view.ViewDebug.__FlagToString._name9135 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "android.view.ViewDebug.FlagToString.name", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__FlagToString._equals9136 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "android.view.ViewDebug.FlagToString.equals", "()I");
				global::android.view.ViewDebug.__FlagToString._mask9137 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "android.view.ViewDebug.FlagToString.mask", "()I");
				global::android.view.ViewDebug.__FlagToString._outputIf9138 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "android.view.ViewDebug.FlagToString.outputIf", "()Z");
				global::android.view.ViewDebug.__FlagToString._equals9139 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "java.lang.annotation.Annotation.equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.__FlagToString._toString9140 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "java.lang.annotation.Annotation.toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__FlagToString._hashCode9141 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "java.lang.annotation.Annotation.hashCode", "()I");
				global::android.view.ViewDebug.__FlagToString._annotationType9142 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "java.lang.annotation.Annotation.annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class HierarchyTraceType : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static HierarchyTraceType()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.HierarchyTraceType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.HierarchyTraceType(@__env);
				}
			}
			internal HierarchyTraceType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values9143;
			public static global::android.view.ViewDebug.HierarchyTraceType[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._values9143));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf9144;
			public static global::android.view.ViewDebug.HierarchyTraceType valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewDebug.HierarchyTraceType>(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._valueOf9144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _BUILD_CACHE9145;
			public static global::android.view.ViewDebug.HierarchyTraceType BUILD_CACHE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _DRAW9146;
			public static global::android.view.ViewDebug.HierarchyTraceType DRAW
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _INVALIDATE9147;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _INVALIDATE_CHILD9148;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _INVALIDATE_CHILD_IN_PARENT9149;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD_IN_PARENT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ON_LAYOUT9150;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_LAYOUT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ON_MEASURE9151;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_MEASURE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _REQUEST_LAYOUT9152;
			public static global::android.view.ViewDebug.HierarchyTraceType REQUEST_LAYOUT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.HierarchyTraceType.staticClass = @__class;
				global::android.view.ViewDebug.HierarchyTraceType._values9143 = @__env.GetStaticMethodID(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._valueOf9144 = @__env.GetStaticMethodID(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$HierarchyTraceType;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface IntToString : java.lang.annotation.Annotation
		{
			int from();
			global::java.lang.String to();
		}

		public partial class IntToString_
		{
			public static global::java.lang.Class _class
			{
				get { return __IntToString.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __IntToString : java.lang.Object, IntToString
		{
			internal static global::java.lang.Class staticClass;
			static __IntToString()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.__IntToString), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.__IntToString(@__env);
				}
			}
			internal __IntToString(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _from9153;
			 int android.view.ViewDebug.IntToString.from() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__IntToString._from9153);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._from9153);
			}
			internal static global::net.sf.jni4net.jni.MethodId _to9154;
			 global::java.lang.String android.view.ViewDebug.IntToString.to() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString._to9154));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._to9154));
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals9155;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__IntToString._equals9155, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._equals9155, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString9156;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString._toString9156));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._toString9156));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hashCode9157;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__IntToString._hashCode9157);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._hashCode9157);
			}
			internal static global::net.sf.jni4net.jni.MethodId _annotationType9158;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString._annotationType9158));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._annotationType9158));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.__IntToString.staticClass = @__class;
				global::android.view.ViewDebug.__IntToString._from9153 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "android.view.ViewDebug.IntToString.from", "()I");
				global::android.view.ViewDebug.__IntToString._to9154 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "android.view.ViewDebug.IntToString.to", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__IntToString._equals9155 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "java.lang.annotation.Annotation.equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.__IntToString._toString9156 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "java.lang.annotation.Annotation.toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__IntToString._hashCode9157 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "java.lang.annotation.Annotation.hashCode", "()I");
				global::android.view.ViewDebug.__IntToString._annotationType9158 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "java.lang.annotation.Annotation.annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class RecyclerTraceType : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static RecyclerTraceType()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.RecyclerTraceType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.RecyclerTraceType(@__env);
				}
			}
			internal RecyclerTraceType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values9159;
			public static global::android.view.ViewDebug.RecyclerTraceType[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._values9159));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf9160;
			public static global::android.view.ViewDebug.RecyclerTraceType valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewDebug.RecyclerTraceType>(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._valueOf9160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _BIND_VIEW9161;
			public static global::android.view.ViewDebug.RecyclerTraceType BIND_VIEW
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP9162;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_FROM_ACTIVE_TO_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MOVE_TO_SCRAP_HEAP9163;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_TO_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NEW_VIEW9164;
			public static global::android.view.ViewDebug.RecyclerTraceType NEW_VIEW
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RECYCLE_FROM_ACTIVE_HEAP9165;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_ACTIVE_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RECYCLE_FROM_SCRAP_HEAP9166;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.RecyclerTraceType.staticClass = @__class;
				global::android.view.ViewDebug.RecyclerTraceType._values9159 = @__env.GetStaticMethodID(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._valueOf9160 = @__env.GetStaticMethodID(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$RecyclerTraceType;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _trace9167;
		public static void trace(android.view.View arg0, android.view.ViewDebug.RecyclerTraceType arg1, int[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace9167, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _trace9168;
		public static void trace(android.view.View arg0, android.view.ViewDebug.HierarchyTraceType arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace9168, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startRecyclerTracing9169;
		public static void startRecyclerTracing(java.lang.String arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startRecyclerTracing9169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopRecyclerTracing9170;
		public static void stopRecyclerTracing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopRecyclerTracing9170);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startHierarchyTracing9171;
		public static void startHierarchyTracing(java.lang.String arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startHierarchyTracing9171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopHierarchyTracing9172;
		public static void stopHierarchyTracing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopHierarchyTracing9172);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpCapturedView9173;
		public static void dumpCapturedView(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._dumpCapturedView9173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewDebug9174;
		public ViewDebug()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._ViewDebug9174, this);
		}
		public static bool TRACE_HIERARCHY
		{
			get
			{
				return false;
			}
		}
		public static bool TRACE_RECYCLER
		{
			get
			{
				return false;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.ViewDebug.staticClass = @__class;
			global::android.view.ViewDebug._trace9167 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$RecyclerTraceType;[I)V");
			global::android.view.ViewDebug._trace9168 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$HierarchyTraceType;)V");
			global::android.view.ViewDebug._startRecyclerTracing9169 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "startRecyclerTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			global::android.view.ViewDebug._stopRecyclerTracing9170 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "stopRecyclerTracing", "()V");
			global::android.view.ViewDebug._startHierarchyTracing9171 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "startHierarchyTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			global::android.view.ViewDebug._stopHierarchyTracing9172 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "stopHierarchyTracing", "()V");
			global::android.view.ViewDebug._dumpCapturedView9173 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "dumpCapturedView", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::android.view.ViewDebug._ViewDebug9174 = @__env.GetMethodID(global::android.view.ViewDebug.staticClass, "<init>", "()V");
		}
	}
}
