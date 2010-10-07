namespace java.security
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class KeyStore : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static KeyStore()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.KeyStore), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.security.KeyStore(@__env);
			}
		}
		protected KeyStore(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface Entry 
		{
		}

		public partial class Entry_
		{
			public static global::java.lang.Class _class
			{
				get { return __Entry.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __Entry : java.lang.Object, Entry
		{
			internal static global::java.lang.Class staticClass;
			static __Entry()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.KeyStore.__Entry), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::java.security.KeyStore.__Entry(@__env);
				}
			}
			internal __Entry(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::java.security.KeyStore.__Entry.staticClass = @__class;
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface LoadStoreParameter 
		{
			global::java.security.KeyStore.ProtectionParameter getProtectionParameter();
		}

		public partial class LoadStoreParameter_
		{
			public static global::java.lang.Class _class
			{
				get { return __LoadStoreParameter.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __LoadStoreParameter : java.lang.Object, LoadStoreParameter
		{
			internal static global::java.lang.Class staticClass;
			static __LoadStoreParameter()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.KeyStore.__LoadStoreParameter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::java.security.KeyStore.__LoadStoreParameter(@__env);
				}
			}
			internal __LoadStoreParameter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _getProtectionParameter13169;
			 global::java.security.KeyStore.ProtectionParameter java.security.KeyStore.LoadStoreParameter.getProtectionParameter() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.security.KeyStore.ProtectionParameter>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStore.__LoadStoreParameter._getProtectionParameter13169));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.security.KeyStore.ProtectionParameter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStore.__LoadStoreParameter.staticClass, global::java.security.KeyStore.__LoadStoreParameter._getProtectionParameter13169));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::java.security.KeyStore.__LoadStoreParameter.staticClass = @__class;
				global::java.security.KeyStore.__LoadStoreParameter._getProtectionParameter13169 = @__env.GetMethodID(global::java.security.KeyStore.__LoadStoreParameter.staticClass, "java.security.KeyStore.LoadStoreParameter.getProtectionParameter", "()Ljava/security/KeyStore$ProtectionParameter;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface ProtectionParameter 
		{
		}

		public partial class ProtectionParameter_
		{
			public static global::java.lang.Class _class
			{
				get { return __ProtectionParameter.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __ProtectionParameter : java.lang.Object, ProtectionParameter
		{
			internal static global::java.lang.Class staticClass;
			static __ProtectionParameter()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.KeyStore.__ProtectionParameter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::java.security.KeyStore.__ProtectionParameter(@__env);
				}
			}
			internal __ProtectionParameter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::java.security.KeyStore.__ProtectionParameter.staticClass = @__class;
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _size13170;
		public virtual int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.security.KeyStore._size13170);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._size13170);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKey13171;
		public virtual global::java.security.Key getKey(java.lang.String arg0, char[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.security.Key>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStore._getKey13171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.security.Key>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getKey13171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13172;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.KeyStore>(@__env, @__env.CallStaticObjectMethodPtr(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance13172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13173;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.KeyStore>(@__env, @__env.CallStaticObjectMethodPtr(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance13173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13174;
		public static global::java.security.KeyStore getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.KeyStore>(@__env, @__env.CallStaticObjectMethodPtr(java.security.KeyStore.staticClass, global::java.security.KeyStore._getInstance13174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _load13175;
		public virtual void load(java.io.InputStream arg0, char[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStore._load13175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._load13175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _load13176;
		public virtual void load(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStore._load13176, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._load13176, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _store13177;
		public virtual void store(java.io.OutputStream arg0, char[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStore._store13177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._store13177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _store13178;
		public virtual void store(java.security.KeyStore.LoadStoreParameter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStore._store13178, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._store13178, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getType13179;
		public virtual global::java.lang.String getType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStore._getType13179));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getType13179));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEntry13180;
		public virtual global::java.security.KeyStore.Entry getEntry(java.lang.String arg0, java.security.KeyStore.ProtectionParameter arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.security.KeyStore.Entry>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStore._getEntry13180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.security.KeyStore.Entry>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getEntry13180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _aliases13181;
		public virtual global::java.util.Enumeration aliases() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStore._aliases13181));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._aliases13181));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEntry13182;
		public virtual void setEntry(java.lang.String arg0, java.security.KeyStore.Entry arg1, java.security.KeyStore.ProtectionParameter arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStore._setEntry13182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setEntry13182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCertificateChain13183;
		public virtual global::java.security.cert.Certificate[] getCertificateChain(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStore._getCertificateChain13183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificateChain13183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProvider13184;
		public virtual global::java.security.Provider getProvider() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Provider>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStore._getProvider13184));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Provider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getProvider13184));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCertificate13185;
		public virtual global::java.security.cert.Certificate getCertificate(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.cert.Certificate>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStore._getCertificate13185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.cert.Certificate>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificate13185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultType13186;
		public static global::java.lang.String getDefaultType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.security.KeyStore.staticClass, global::java.security.KeyStore._getDefaultType13186));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCreationDate13187;
		public virtual global::java.util.Date getCreationDate(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStore._getCreationDate13187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCreationDate13187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKeyEntry13188;
		public virtual void setKeyEntry(java.lang.String arg0, byte[] arg1, java.security.cert.Certificate[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStore._setKeyEntry13188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setKeyEntry13188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKeyEntry13189;
		public virtual void setKeyEntry(java.lang.String arg0, java.security.Key arg1, char[] arg2, java.security.cert.Certificate[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStore._setKeyEntry13189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setKeyEntry13189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCertificateEntry13190;
		public virtual void setCertificateEntry(java.lang.String arg0, java.security.cert.Certificate arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStore._setCertificateEntry13190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._setCertificateEntry13190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteEntry13191;
		public virtual void deleteEntry(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.KeyStore._deleteEntry13191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._deleteEntry13191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsAlias13192;
		public virtual bool containsAlias(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.KeyStore._containsAlias13192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._containsAlias13192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isKeyEntry13193;
		public virtual bool isKeyEntry(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.KeyStore._isKeyEntry13193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._isKeyEntry13193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCertificateEntry13194;
		public virtual bool isCertificateEntry(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.KeyStore._isCertificateEntry13194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._isCertificateEntry13194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCertificateAlias13195;
		public virtual global::java.lang.String getCertificateAlias(java.security.cert.Certificate arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.KeyStore._getCertificateAlias13195, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._getCertificateAlias13195, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _entryInstanceOf13196;
		public virtual bool entryInstanceOf(java.lang.String arg0, java.lang.Class arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.KeyStore._entryInstanceOf13196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.KeyStore.staticClass, global::java.security.KeyStore._entryInstanceOf13196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _KeyStore13197;
		protected KeyStore(java.security.KeyStoreSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.KeyStore.staticClass, global::java.security.KeyStore._KeyStore13197, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.KeyStore.staticClass = @__class;
			global::java.security.KeyStore._size13170 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "size", "()I");
			global::java.security.KeyStore._getKey13171 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "getKey", "(Ljava/lang/String;[C)Ljava/security/Key;");
			global::java.security.KeyStore._getInstance13172 = @__env.GetStaticMethodID(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyStore;");
			global::java.security.KeyStore._getInstance13173 = @__env.GetStaticMethodID(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyStore;");
			global::java.security.KeyStore._getInstance13174 = @__env.GetStaticMethodID(global::java.security.KeyStore.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyStore;");
			global::java.security.KeyStore._load13175 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "load", "(Ljava/io/InputStream;[C)V");
			global::java.security.KeyStore._load13176 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "load", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStore._store13177 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "store", "(Ljava/io/OutputStream;[C)V");
			global::java.security.KeyStore._store13178 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "store", "(Ljava/security/KeyStore$LoadStoreParameter;)V");
			global::java.security.KeyStore._getType13179 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "getType", "()Ljava/lang/String;");
			global::java.security.KeyStore._getEntry13180 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "getEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/KeyStore$Entry;");
			global::java.security.KeyStore._aliases13181 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "aliases", "()Ljava/util/Enumeration;");
			global::java.security.KeyStore._setEntry13182 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "setEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$ProtectionParameter;)V");
			global::java.security.KeyStore._getCertificateChain13183 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;");
			global::java.security.KeyStore._getProvider13184 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.KeyStore._getCertificate13185 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "getCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;");
			global::java.security.KeyStore._getDefaultType13186 = @__env.GetStaticMethodID(global::java.security.KeyStore.staticClass, "getDefaultType", "()Ljava/lang/String;");
			global::java.security.KeyStore._getCreationDate13187 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "getCreationDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.security.KeyStore._setKeyEntry13188 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "setKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStore._setKeyEntry13189 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "setKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStore._setCertificateEntry13190 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "setCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V");
			global::java.security.KeyStore._deleteEntry13191 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "deleteEntry", "(Ljava/lang/String;)V");
			global::java.security.KeyStore._containsAlias13192 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "containsAlias", "(Ljava/lang/String;)Z");
			global::java.security.KeyStore._isKeyEntry13193 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "isKeyEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStore._isCertificateEntry13194 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "isCertificateEntry", "(Ljava/lang/String;)Z");
			global::java.security.KeyStore._getCertificateAlias13195 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "getCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;");
			global::java.security.KeyStore._entryInstanceOf13196 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "entryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z");
			global::java.security.KeyStore._KeyStore13197 = @__env.GetMethodID(global::java.security.KeyStore.staticClass, "<init>", "(Ljava/security/KeyStoreSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
