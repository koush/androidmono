namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLOutput_))]
	public interface SQLOutput  : global::MonoJavaBridge.IJavaObject 
	{
		void writeObject(java.sql.SQLData arg0);
		void writeInt(int arg0);
		void writeBytes(byte[] arg0);
		void writeLong(long arg0);
		void writeByte(byte arg0);
		void writeShort(short arg0);
		void writeFloat(float arg0);
		void writeString(java.lang.String arg0);
		void writeDouble(double arg0);
		void writeArray(java.sql.Array arg0);
		void writeBoolean(bool arg0);
		void writeBigDecimal(java.math.BigDecimal arg0);
		void writeDate(java.sql.Date arg0);
		void writeTime(java.sql.Time arg0);
		void writeTimestamp(java.sql.Timestamp arg0);
		void writeCharacterStream(java.io.Reader arg0);
		void writeAsciiStream(java.io.InputStream arg0);
		void writeBinaryStream(java.io.InputStream arg0);
		void writeRef(java.sql.Ref arg0);
		void writeBlob(java.sql.Blob arg0);
		void writeClob(java.sql.Clob arg0);
		void writeStruct(java.sql.Struct arg0);
		void writeURL(java.net.URL arg0);
		void writeNString(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLOutput))]
	public sealed partial class SQLOutput_ : java.lang.Object, SQLOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLOutput_()
		{
			InitJNI();
		}
		internal SQLOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeObject24888;
		 void java.sql.SQLOutput.writeObject(java.sql.SQLData arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeObject24888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeObject24888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeInt24889;
		 void java.sql.SQLOutput.writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeInt24889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeInt24889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes24890;
		 void java.sql.SQLOutput.writeBytes(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBytes24890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBytes24890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong24891;
		 void java.sql.SQLOutput.writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeLong24891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeLong24891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte24892;
		 void java.sql.SQLOutput.writeByte(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeByte24892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeByte24892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort24893;
		 void java.sql.SQLOutput.writeShort(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeShort24893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeShort24893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat24894;
		 void java.sql.SQLOutput.writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeFloat24894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeFloat24894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeString24895;
		 void java.sql.SQLOutput.writeString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeString24895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeString24895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble24896;
		 void java.sql.SQLOutput.writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeDouble24896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeDouble24896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeArray24897;
		 void java.sql.SQLOutput.writeArray(java.sql.Array arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeArray24897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeArray24897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean24898;
		 void java.sql.SQLOutput.writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBoolean24898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBoolean24898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBigDecimal24899;
		 void java.sql.SQLOutput.writeBigDecimal(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBigDecimal24899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBigDecimal24899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDate24900;
		 void java.sql.SQLOutput.writeDate(java.sql.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeDate24900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeDate24900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTime24901;
		 void java.sql.SQLOutput.writeTime(java.sql.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeTime24901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeTime24901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTimestamp24902;
		 void java.sql.SQLOutput.writeTimestamp(java.sql.Timestamp arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeTimestamp24902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeTimestamp24902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeCharacterStream24903;
		 void java.sql.SQLOutput.writeCharacterStream(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeCharacterStream24903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeCharacterStream24903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeAsciiStream24904;
		 void java.sql.SQLOutput.writeAsciiStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeAsciiStream24904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeAsciiStream24904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBinaryStream24905;
		 void java.sql.SQLOutput.writeBinaryStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBinaryStream24905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBinaryStream24905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeRef24906;
		 void java.sql.SQLOutput.writeRef(java.sql.Ref arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeRef24906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeRef24906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBlob24907;
		 void java.sql.SQLOutput.writeBlob(java.sql.Blob arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBlob24907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBlob24907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeClob24908;
		 void java.sql.SQLOutput.writeClob(java.sql.Clob arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeClob24908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeClob24908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStruct24909;
		 void java.sql.SQLOutput.writeStruct(java.sql.Struct arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeStruct24909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeStruct24909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeURL24910;
		 void java.sql.SQLOutput.writeURL(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeURL24910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeURL24910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeNString24911;
		 void java.sql.SQLOutput.writeNString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeNString24911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeNString24911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLOutput"));
			global::java.sql.SQLOutput_._writeObject24888 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeObject", "(Ljava/sql/SQLData;)V");
			global::java.sql.SQLOutput_._writeInt24889 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeInt", "(I)V");
			global::java.sql.SQLOutput_._writeBytes24890 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBytes", "([B)V");
			global::java.sql.SQLOutput_._writeLong24891 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeLong", "(J)V");
			global::java.sql.SQLOutput_._writeByte24892 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeByte", "(B)V");
			global::java.sql.SQLOutput_._writeShort24893 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeShort", "(S)V");
			global::java.sql.SQLOutput_._writeFloat24894 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeFloat", "(F)V");
			global::java.sql.SQLOutput_._writeString24895 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeString", "(Ljava/lang/String;)V");
			global::java.sql.SQLOutput_._writeDouble24896 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeDouble", "(D)V");
			global::java.sql.SQLOutput_._writeArray24897 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeArray", "(Ljava/sql/Array;)V");
			global::java.sql.SQLOutput_._writeBoolean24898 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBoolean", "(Z)V");
			global::java.sql.SQLOutput_._writeBigDecimal24899 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBigDecimal", "(Ljava/math/BigDecimal;)V");
			global::java.sql.SQLOutput_._writeDate24900 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeDate", "(Ljava/sql/Date;)V");
			global::java.sql.SQLOutput_._writeTime24901 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeTime", "(Ljava/sql/Time;)V");
			global::java.sql.SQLOutput_._writeTimestamp24902 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeTimestamp", "(Ljava/sql/Timestamp;)V");
			global::java.sql.SQLOutput_._writeCharacterStream24903 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeCharacterStream", "(Ljava/io/Reader;)V");
			global::java.sql.SQLOutput_._writeAsciiStream24904 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeAsciiStream", "(Ljava/io/InputStream;)V");
			global::java.sql.SQLOutput_._writeBinaryStream24905 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBinaryStream", "(Ljava/io/InputStream;)V");
			global::java.sql.SQLOutput_._writeRef24906 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeRef", "(Ljava/sql/Ref;)V");
			global::java.sql.SQLOutput_._writeBlob24907 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBlob", "(Ljava/sql/Blob;)V");
			global::java.sql.SQLOutput_._writeClob24908 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeClob", "(Ljava/sql/Clob;)V");
			global::java.sql.SQLOutput_._writeStruct24909 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeStruct", "(Ljava/sql/Struct;)V");
			global::java.sql.SQLOutput_._writeURL24910 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeURL", "(Ljava/net/URL;)V");
			global::java.sql.SQLOutput_._writeNString24911 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeNString", "(Ljava/lang/String;)V");
		}
	}
}
